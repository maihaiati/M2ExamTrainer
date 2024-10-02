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
    /// Interaction logic for QuesItem.xaml
    /// </summary>
    public partial class QuesItem : UserControl
    {
        private int numQues;
        private Question question;

        public event EventHandler QuesItemClick;
        public event EventHandler QuesItemDelete;

        protected virtual void OnQuesItemClick()
        {
            if (QuesItemClick != null)
            {
                QuesItemClick(this, EventArgs.Empty);
            }
        }

        protected virtual void OnQuesItemDelete()
        {
            if (QuesItemDelete != null)
            {
                QuesItemDelete(this, EventArgs.Empty);
            }
        }

        public QuesItem(int numQues, Question question)
        {
            InitializeComponent();

            this.numQues = numQues;
            this.question = question;

            lblNumQues.Content = "Câu " + numQues;

            btnDel.Content = FindResource("ButtonDel");
        }

        public int getNumQues() { 
            return numQues;
        }

        public void setNumQues(int numQues) { 
            this.numQues = numQues;
        }

        public Question getQuestion() { 
            return question;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            OnQuesItemClick();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            OnQuesItemDelete();
        }
    }
}
