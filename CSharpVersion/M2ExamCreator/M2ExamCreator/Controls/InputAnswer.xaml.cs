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
using Color = System.Windows.Media.Color;
using ColorConverter = System.Windows.Media.ColorConverter;
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
            loadData();
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

        private void loadData() // Hàm load dữ liệu
        {
            if (answer != null)
            {
                setContent(richAns, answer.Content);
                if (answer.TrueAnswer)
                {
                    lblTitle.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00FFB3"));
                    cbTrue.IsChecked = true;
                }
            }
        }

        public void saveData() // Hàm lưu dữ liệu
        {
            if (answer != null)
            {
                answer.Content = getContent(richAns);
                if (cbTrue.IsChecked == true) answer.TrueAnswer = true;
                else answer.TrueAnswer = false;
            }
        }

        public bool isTrueAnswer()
        {
            if (cbTrue.IsChecked == true) return true;
            return false;
        }

        private void cbTrue_CheckedChange(object sender, RoutedEventArgs e)
        {
            if (cbTrue.IsChecked == true) lblTitle.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00FFB3"));
            else lblTitle.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }
    }
}
