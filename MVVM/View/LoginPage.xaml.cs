using System;
using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using PokeBattle_Hamed.Model;

namespace WpfApp1
{
    public partial class LoginPage : Window
    {
        private readonly string _connectionString;
        private readonly AppDbContext _dbContext;

        public LoginPage(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

            // Configurer la connexion à la base de données
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(_connectionString);
            _dbContext = new AppDbContext(optionsBuilder.Options);
        }

        private void CreateAccountButton_Click(object sender, RoutedEventArgs e)
        {
            string username = CreateUsernameTextBox.Text;  // Utilisation correcte du nom
            string password = CreatePasswordBox.Password;  // Utilisation correcte du nom

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            try
            {
                // Vérifier si le nom d'utilisateur existe déjà
                var existingUser = _dbContext.Logins.FirstOrDefault(u => u.Username == username);
                if (existingUser != null)
                {
                    MessageBox.Show("Nom d'utilisateur déjà pris. Veuillez en choisir un autre.");
                    return;
                }

                // Hacher le mot de passe (simplifié pour l'exemple)
                string passwordHash = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));

                // Créer un nouvel utilisateur
                var newUser = new Login
                {
                    Username = username,
                    PasswordHash = passwordHash
                };

                // Sauvegarder dans la base de données
                _dbContext.Logins.Add(newUser);
                _dbContext.SaveChanges();

                MessageBox.Show("Compte créé avec succès !");
                CreateUsernameTextBox.Clear();
                CreatePasswordBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la création du compte : {ex.Message}");
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = LoginUsernameTextBox.Text;  // Utilisation correcte du nom
            string password = LoginPasswordBox.Password;  // Utilisation correcte du nom

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            try
            {
                // Hacher le mot de passe (simplifié)
                string passwordHash = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));

                // Vérifier les informations d'identification
                var user = _dbContext.Logins.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);
                if (user == null)
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !");
                }
                else
                {
                    MessageBox.Show("Connexion réussie !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}");
            }
        }
    }
}
