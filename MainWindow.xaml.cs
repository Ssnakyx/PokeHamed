using System.Windows;

namespace WpfApp1
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

        // Gestionnaire pour le bouton "Sign Up"
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Créer et afficher la nouvelle fenêtre
            SecondaryWindow secondaryWindow = new SecondaryWindow();
            secondaryWindow.Show();
        }

        // Gestionnaire pour le bouton "Login" (à adapter si nécessaire)
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Login button clicked!");
        }
    }
}
