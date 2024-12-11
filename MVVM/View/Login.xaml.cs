using System.Windows;
using System.Windows.Controls;
using PokeBattle_Hamed.ViewModels;
using PokemonLike.ViewModels;

namespace PokemonLike.Views
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        // Action du bouton Login
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string passwordHash = PasswordBox.Password; // Assurez-vous de hasher le mot de passe avant de le stocker

            // Utilisation de la logique de connexion
            var loginAccount = new LoginAccount(new Data.PokemonDbContext());
            bool isAuthenticated = loginAccount.AuthenticateUser(username, passwordHash);

            if (isAuthenticated)
            {
                MessageBox.Show("Connexion réussie !");
                // Ouvrir la fenêtre principale ou une autre fenêtre après la connexion réussie
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

        // Retour à la fenêtre principale
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Fermer la fenêtre de login
        }
    }
}
