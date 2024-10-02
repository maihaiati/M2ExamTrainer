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
    /// Interaction logic for InputQues.xaml
    /// </summary>
    public partial class InputQues : UserControl
    {
        private int numQues;
        private Question question;

        public InputQues(int numQues = 0, Question question = null)
        {
            InitializeComponent();

            this.numQues = numQues;
            this.question = question;

            lblTitle.Content = "Câu hỏi " + numQues;
            loadData();
        }

        private void loadData()
        {

        }
    }
}
