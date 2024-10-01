using Google.Protobuf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace M2ExamTrainer.Classes
{
    class QuickAction
    {
        public static string GetDir()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                } else
                {
                    return "CANCEL_SELECT_DIR";
                }
            }
        }

        public static string GetFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Exam Files (*.exam)|*.exam;";

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(dialog.FileName)) 
                {
                    string fileName = dialog.FileName;
                    return fileName;
                } 
                else if (result == DialogResult.Cancel)
                {
                    return "CANCEL_SELECT_FILE";
                }
                return String.Empty;
            }
        }

        private static void SaveStreamToFile(string dir, byte[] data)
        {
            try
            {
                using (var fileStream = new FileStream(dir, FileMode.Create, FileAccess.Write))
                {
                    fileStream.Write(data, 0, data.Length);
                }
            } 
            catch (Exception e) 
            {
                MessageBox.Show("Đã xảy ra lỗi không xác định!\nMã lỗi: " + e.ToString(), "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        public static bool CreateExam(string dir, string name, string fileName, string author, Int64 minute)
        {
            if (name == "")
            {
                return false;
            }

            string examDir = dir + "\\" + name;
            string examFile = examDir + "\\" + fileName + ".exam";
            string assetsDir = examDir + "\\assets";

            try
            {
                if (Directory.Exists(examDir))
                {
                    MessageBox.Show("Đã có thư mục đề thi tên " + name + " tồn tại!", "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                DirectoryInfo examFolder = Directory.CreateDirectory(examDir);
                DirectoryInfo assetFolder = Directory.CreateDirectory(assetsDir);
            }
            catch (Exception e)
            {
                MessageBox.Show("Đã xảy ra lỗi không xác định!\nMã lỗi: " + e.ToString(), "M2ExamCreator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Exam exam = new Exam();

            exam.Name = name;
            exam.Author = author;
            exam.NumOfQues = 0;
            exam.Minute = minute;

            using (var stream = new MemoryStream())
            {
                exam.WriteTo(stream);
                var serializedData = stream.ToArray();

                SaveStreamToFile(examFile, serializedData);
            }
            return true;
        }

        public static Exam ReadExam(string dir)
        {
            Exam exam = new Exam();
            try
            {
                using (var input = File.OpenRead(dir))
                {
                    exam = Exam.Parser.ParseFrom(input);
                }
            }
            catch {
                MessageBox.Show("Đề thi không hợp lệ!", "M2ExamTrainer", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Environment.Exit(0);
                return null;
            }
            return exam;
        }
    }
}
