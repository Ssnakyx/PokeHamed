using System.Windows;

namespace WpfApp1
{
    public partial class CreateAccountPage : Window
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        // Méthode pour gérer l'action de création du compte
        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            string username = CreateUsernameTextBox.Text;  // Utilisation du nom défini dans le XAML
            string password = CreatePasswordBox.Password;  // Utilisation du nom défini dans le XAML

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Logique pour créer un compte ici
            MessageBox.Show($"Compte créé pour {username} !");
        }
    }
}
