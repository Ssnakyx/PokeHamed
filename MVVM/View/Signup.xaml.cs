using System.Windows;
using System.Windows.Controls;
using PokeBattle_Hamed.ViewModels;
using PokemonLike.ViewModels;

namespace PokemonLike.Views
{
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        // Action du bouton Sign Up
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string passwordHash = PasswordBox.Password; // Assurez-vous de hasher le mot de passe avant de le stocker

            // Utilisation de la logique de création de compte
            var signupAccount = new SignupAccount(new Data.PokemonDbContext());
            bool isCreated = signupAccount.CreateUser(username, passwordHash);

            if (isCreated)
            {
                MessageBox.Show("Utilisateur créé avec succès !");
                // Naviguer vers la fenêtre de login ou une autre fenêtre après l'inscription
                this.Close();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur déjà pris.");
            }
        }

        // Retour à la fenêtre principale
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close(); // Fermer la fenêtre d'inscription
        }
    }
}
