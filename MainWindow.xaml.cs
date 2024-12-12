using System;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using PokeBattle_Hamed.Model;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ValidateConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = DatabaseLinkTextBox.Text;

            // Vérification de la connexion à la base de données
            try
            {
                var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
                optionsBuilder.UseSqlServer(connectionString);

                using (var dbContext = new AppDbContext(optionsBuilder.Options))
                {
                    dbContext.Database.CanConnect(); // Essaie de se connecter à la base
                    MessageBox.Show("Connexion réussie à la base de données !");

                    // Logique pour ouvrir la fenêtre de connexion ou de création de compte
                    // Ici, nous pouvons directement ouvrir la fenêtre LoginPage ou CreateAccountPage
                    var loginPage = new LoginPage(connectionString);
                    loginPage.Show();
                    this.Close(); // Ferme la fenêtre principale après la connexion réussie
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}");
            }
        }
    }
}
