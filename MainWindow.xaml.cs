using System.Windows;
using PokemonLike.View;  // Importer le namespace des fenêtres SignUp et Login

namespace PokemonLike
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Ouvrir la fenêtre SignUp
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow();
            signUpWindow.Show();  // Affiche la fenêtre SignUp
        }

        // Ouvrir la fenêtre Login
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();  // Affiche la fenêtre Login
        }
    }
}
