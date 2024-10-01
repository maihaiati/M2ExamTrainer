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

        public QuesItem(int numQues)
        {
            InitializeComponent();

            this.numQues = numQues;
            btnDel.Content = FindResource("btnDel");
        }

        public int getNumQues() { return numQues; }

        public void setNumQues(int numQues) { this.numQues = numQues; }
    }
}
