using M2ExamTrainer.Classes;
using M2ExamTrainer.SubUserControls;
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
using MessageBox = System.Windows.MessageBox;

namespace M2ExamTrainer
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

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            string dir = QuickAction.GetDir();
            if (dir != "CANCEL_SELECT")
            {
                //ExamInfo examInfo = new ExamInfo(QuickAction.ReadExam(dir));
                ExamInfo examInfo = new ExamInfo(null);

                MainGrid.Children.Clear();
                MainGrid.Children.Add(examInfo);
            }
        }
    }
}