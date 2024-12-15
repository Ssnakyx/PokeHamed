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
using WpfApp1.MVVM.ViewModel;


namespace WpfApp1
{
 
    public partial class MainWindow : Window
    {
        public MainWindowVM mainWindowVM { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            mainWindowVM = new MainWindowVM();

            DataContext = mainWindowVM;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}