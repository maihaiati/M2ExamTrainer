using M2ExamCreator.SubUserControls;
using M2ExamTrainer.Classes;
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

namespace M2ExamCreator
{
    /// <summary>
    /// Interaction logic for Startup.xaml
    /// </summary>
    public partial class Startup : UserControl
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            CreateExam createExam = new CreateExam();

            mainWindow.MainGrid.Children.Clear();
            mainWindow.MainGrid.Children.Add(createExam);
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            string examFile = QuickAction.GetFile();

            if (!String.IsNullOrWhiteSpace(examFile) && examFile != "CANCEL_SELECT_FILE")
            {
                MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
                EditExam editExam = new EditExam(examFile);

                mainWindow.MainGrid.Children.Clear();
                mainWindow.MainGrid.Children.Add(editExam);
            }
        }
    }
}
