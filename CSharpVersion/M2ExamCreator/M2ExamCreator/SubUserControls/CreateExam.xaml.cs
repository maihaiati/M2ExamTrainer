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
using UserControl = System.Windows.Controls.UserControl;
using Application = System.Windows.Application;
using MessageBox = System.Windows.Forms.MessageBox;
using M2ExamTrainer.Classes;


namespace M2ExamCreator.SubUserControls
{
    /// <summary>
    /// Interaction logic for CreateExam.xaml
    /// </summary>
    public partial class CreateExam : UserControl
    {
        public CreateExam()
        {
            InitializeComponent();

            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            mainWindow.Title = "M2ExamCreator - Create exam";
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            

            string name = txtName.Text;
            string fileName = txtFileName.Text;
            string author = txtAuthor.Text;
            Int64 minute = 0;

            if (name.Length == 0 || fileName.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ các trường bắt buộc!", "M2ExamCreator",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMinute.Text.Length > 0)
            {
                try
                {
                    minute = Int64.Parse(txtMinute.Text);
                }
                catch
                {
                    MessageBox.Show("Thời gian làm bài không hợp lệ!", "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string dir = QuickAction.GetDir();
            string examDir = dir + "\\" + name;
            string examFile = examDir + "\\" + fileName + ".exam";

            try
            {
                if (QuickAction.CreateExam(dir, name, fileName, author, minute))
                {
                    EditExam editExam = new EditExam(examFile);
                    mainWindow.MainGrid.Children.Clear();
                    mainWindow.MainGrid.Children.Add(editExam);
                }
                else
                {
                    MessageBox.Show("Tạo đề thi thất bại!", "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không xác định!\nMã lỗi: " + ex.ToString(), "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
