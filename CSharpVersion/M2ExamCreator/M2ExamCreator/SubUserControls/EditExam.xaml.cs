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
using Application = System.Windows.Application;
using UserControl = System.Windows.Controls.UserControl;

namespace M2ExamCreator.SubUserControls
{
    /// <summary>
    /// Interaction logic for EditExam.xaml
    /// </summary>
    public partial class EditExam : UserControl
    {
        private string examFile;

        public EditExam(string examFile)
        {
            InitializeComponent();

            this.examFile = examFile;

            MainWindow mainWindow = (MainWindow) Application.Current.MainWindow;
            mainWindow.Title = "M2ExamCreator - Edit exam";
        }
    }
}
