using System.Windows;

namespace PokemonLike
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Gestionnaire d'événement pour le bouton "Sign Up"
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fonctionnalité Sign Up à implémenter.");
        }

        // Gestionnaire d'événement pour le bouton "Login"
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Fonctionnalité Login à implémenter.");
        }
    }
}
