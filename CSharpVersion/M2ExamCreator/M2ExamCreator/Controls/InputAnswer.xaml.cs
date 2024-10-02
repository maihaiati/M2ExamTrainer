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

namespace M2ExamCreator.Controls
{
    /// <summary>
    /// Interaction logic for InputAnswer.xaml
    /// </summary>
    public partial class InputAnswer : UserControl
    {
        private int numQues;
        private Answer answer;

        public InputAnswer(int numQues, Answer answer)
        {
            InitializeComponent();

            this.numQues = numQues;
            this.answer = answer;
            loadNumQues();
        }

        private void loadNumQues()
        {
            lblTitle.Content = "Đáp án " + numQues;
        }

        public int getNumQues() { 
            return numQues;
        }

        public Answer getAnswer() { 
            return answer; 
        }

        public void setNumQues(int numQues) { 
            this.numQues = numQues;
            loadNumQues();
        }
    }
}
