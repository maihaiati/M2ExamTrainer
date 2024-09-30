using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    return "CANCEL_SELECT";
                }
            }
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
                Application.Exit();
            }
            return exam;
        }
    }
}
