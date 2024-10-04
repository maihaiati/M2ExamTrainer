﻿using System;
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
using RichTextBox = System.Windows.Controls.RichTextBox;
using UserControl = System.Windows.Controls.UserControl;

namespace M2ExamCreator.Controls
{
    /// <summary>
    /// Interaction logic for InputAnswer.xaml
    /// </summary>
    public partial class InputAnswer : UserControl
    {
        private int numAns;
        private Answer answer;

        public InputAnswer(int numAns = 0, Answer answer = null)
        {
            InitializeComponent();

            this.numAns = numAns;
            this.answer = answer;
            loadNumAns();
        }

        private void loadNumAns()
        {
            lblTitle.Content = "Đáp án " + numAns;
        }

        public int getNumAnd() { 
            return numAns;
        }

        public void setNumQues(int numAns) { 
            this.numAns = numAns;
            loadNumAns();
        }

        private string getContent(RichTextBox richTextBox)
        {
            TextRange textRange = new TextRange(
                richTextBox.Document.ContentStart,
                richTextBox.Document.ContentEnd
            );
            return textRange.Text;
        }

        private void setContent(RichTextBox richTextBox, string text)
        {
            TextRange textRange = new TextRange(
                richTextBox.Document.ContentStart,
                richTextBox.Document.ContentEnd
            );
            textRange.Text = text;
        }

        private void loadData()
        {
            if (answer != null)
            {
                setContent(richAns, answer.Content);
            }
        }

        public void saveData()
        {
            if (answer != null)
            {
                answer.Content = getContent(richAns);
            }
        }
    }
}
