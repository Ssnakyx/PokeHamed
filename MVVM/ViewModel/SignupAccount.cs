using PokeBattle_Hamed.Data;
using PokeBattle_Hamed.Model;
using System.Linq;

namespace PokemonLike.ViewModels
{
    public class SignupAccount
    {
        private readonly PokemonDbContext _context;

        public SignupAccount(PokemonDbContext context)
        {
            _context = context;
        }

        // Méthode pour créer un nouvel utilisateur
        public bool CreateUser(string username, string passwordHash)
        {
            // Vérifier si le nom d'utilisateur existe déjà
            if (_context.Logins.Any(u => u.Username == username))
            {
                return false; // L'utilisateur existe déjà
            }

            // Créer un nouvel utilisateur et l'ajouter à la base de données
            var newUser = new Login
            {
                Username = username,
                PasswordHash = passwordHash
            };

            _context.Logins.Add(newUser);
            _context.SaveChanges(); // Sauvegarder les modifications
            return true;
        }
    }
}
