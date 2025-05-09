﻿using M2ExamCreator.Controls;
using M2ExamTrainer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Application = System.Windows.Application;
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;
using MessageBox = System.Windows.Forms.MessageBox;
using Panel = System.Windows.Controls.Panel;
using UserControl = System.Windows.Controls.UserControl;

namespace M2ExamCreator.SubUserControls
{
    /// <summary>
    /// Interaction logic for EditExam.xaml
    /// </summary>
    public partial class EditExam : UserControl
    {
        private string examFile; // Đường dẫn đến file exam
        private Exam exam;

        private int numOfQues; // Số lượng câu hỏi trong exam
        private QuesItem selectedQues = null;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public EditExam(string examFile)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(examFile))
            {
                MessageBox.Show("Đề thi không hợp lệ!", "M2ExamCreator",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            this.examFile = examFile;

            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            mainWindow.Title = "M2ExamCreator - Edit exam";

            loadData();
        }

        private void loadData()
        {
            exam = QuickAction.ReadExam(examFile);

            numOfQues = exam.Questions.Count;

            for (int i = 0; i < numOfQues; i++)
            {
                QuesItem quesItem = new QuesItem(i + 1, exam.Questions.ElementAt(i));

                // Add event handler
                quesItem.QuesItemClick += OnQuesItemClick;
                quesItem.QuesItemDelete += OnQuesItemDelete;

                panelQuesList.Children.Add(quesItem);
            }
            if (numOfQues > 0)
            {
                try
                {
                    loadQues((QuesItem)panelQuesList.Children[numOfQues - 1]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi không xác định!\nMã lỗi: " + ex.ToString(), "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadQues(QuesItem quesItem)
        {
            panelEditQues.Children.Clear();
            if (quesItem == null)
            {
                selectedQues = null;
                return;
            }
            quesItem.recBackground.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD80077")); // Đặt màu sắc cho item được chọn
            if (selectedQues == quesItem) return;
            if (selectedQues != null) selectedQues.recBackground.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5B5B5B")); // Đặt màu sắc cũ cho item bỏ chọn

            selectedQues = quesItem;
            InputQues inputQues = new InputQues(quesItem.getNumQues(), quesItem.getQuestion());
            panelEditQues.Children.Add(inputQues);

            // Load các đáp án của câu hỏi
            for (int i = 0; i < quesItem.getQuestion().Answers.Count; i++)
            {
                InputAnswer inputAnswer = new InputAnswer(i + 1, quesItem.getQuestion().Answers.ElementAt(i)); // Khởi tạo đối tượng nhập đáp án, đối tượng này cũng sẽ khởi tạo giống đổi tượng InputQues
                panelEditQues.Children.Add(inputAnswer);
            }
        }

        private void btnNewAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (selectedQues == null)
            {
                MessageBox.Show("Hãy tạo một câu hỏi trước khi thêm đáp án!", "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Answer answer = new Answer();
            answer.Id = DateTime.Now.Ticks;
            selectedQues.getQuestion().Answers.Add(answer);

            InputAnswer inputAnswer = new InputAnswer(selectedQues.getQuestion().Answers.Count, answer);
            panelEditQues.Children.Add(inputAnswer);
        }

        private void btnNewQues_Click(object sender, RoutedEventArgs e)
        {
            numOfQues++;
            Question question = new Question();
            question.Id = DateTime.Now.Ticks;
            exam.Questions.Add(question);

            QuesItem quesItem = new QuesItem(numOfQues, question);

            // Add event handler
            quesItem.QuesItemClick += OnQuesItemClick;
            quesItem.QuesItemDelete += OnQuesItemDelete;
            
            panelQuesList.Children.Add(quesItem);

            // Save old seleted question
            callSaveData();

            // After save change ques to new ques
            loadQues(quesItem);
        }

        private void callSaveData()
        {
            if (selectedQues == null) return;
            if (panelEditQues.Children.Count == 0)
            {
                MessageBox.Show("Đã xảy ra lỗi không xác định liên quan đến việc lưu trữ nội dung đề thi. Vui lòng sao lưu nội dung để tránh bị mất mát dữ liệu!", "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save question
            //((InputQues)panelEditQues.Children[0]).saveData();

            // Save answer
            int countTrueAnswer = 0;
            for (int i = 1; i < panelEditQues.Children.Count; i++)
            {
                //((InputAnswer)panelEditQues.Children[i]).saveData();
                if (((InputAnswer)panelEditQues.Children[i]).isTrueAnswer()) countTrueAnswer++;
            }
            if (countTrueAnswer > 1)
            {
                selectedQues.getQuestion().MultiAnswer = true;
            }
            QuickAction.WriteExam(exam, examFile);
        }

        private void OnQuesItemClick(object sender, EventArgs e)
        {
            if ((QuesItem)sender == selectedQues) return;

            // Lưu nội dung trước khi chuyển câu
            callSaveData();

            loadQues((QuesItem)sender);
        }

        private void OnQuesItemDelete(object sender, EventArgs e)
        {
            numOfQues--;
            Question question = ((QuesItem)sender).getQuestion();
            for (int i = 0; i < exam.Questions.Count; i++) { // Remove question element in exam
                if (question.Id == exam.Questions[i].Id)
                {
                    exam.Questions.RemoveAt(i);
                }
            }
            for (int i = 0; i < panelQuesList.Children.Count; i++) // Remove quesitem element in stack panel & reorder num ques
            {
                if (((QuesItem)panelQuesList.Children[i]).getQuestion().Id == question.Id)
                {
                    panelQuesList.Children.RemoveAt(i);
                    for (int j = i; j < panelQuesList.Children.Count; j++) // Reorder num ques
                    {
                        ((QuesItem)panelQuesList.Children[j]).setNumQues(j + 1);
                    }
                }
            }
            // Remove event handler
            ((QuesItem)sender).QuesItemClick -= OnQuesItemClick;
            ((QuesItem)sender).QuesItemDelete -= OnQuesItemDelete;

            // Change selected ques
            if (((QuesItem)sender) == selectedQues)
            {
                if (selectedQues.getNumQues() > 1)
                {
                    for (int i = 0; i < panelQuesList.Children.Count; i++)
                    {
                        if (((QuesItem)panelQuesList.Children[i]).getNumQues() == selectedQues.getNumQues() - 1) 
                            loadQues((QuesItem)panelQuesList.Children[i]);
                    }
                }
                else loadQues(null);
            }

            // Save data
            callSaveData();
        }

        private void OnUnloaded()
        {

        }
    }
}
