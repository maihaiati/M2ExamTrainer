using M2ExamCreator.SubUserControls;
using M2ExamTrainer.Classes;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M2ExamCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateExam createExam = new CreateExam();

            MainGrid.Children.Clear();
            MainGrid.Children.Add(createExam);
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            string examFile = QuickAction.GetFile();
        }
    }
}