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

namespace M2ExamTrainer.SubUserControls
{
    /// <summary>
    /// Interaction logic for ExamInfo.xaml
    /// </summary>
    public partial class ExamInfo : UserControl
    {
        private Exam exam;

        public ExamInfo(Exam exam)
        {
            InitializeComponent();

            this.exam = exam;
        }
    }
}
