using PokeBattle_Hamed.Data;
using PokeBattle_Hamed.Model;
using System.Linq;

namespace PokemonLike.ViewModels
{
    public class LoginAccount
    {
        private readonly PokemonDbContext _context;

        public LoginAccount(PokemonDbContext context)
        {
            _context = context;
        }

        // Méthode pour authentifier l'utilisateur
        public bool AuthenticateUser(string username, string passwordHash)
        {
            // Vérifier si le nom d'utilisateur et le mot de passe correspondent
            var user = _context.Logins.FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);
            return user != null;
        }
    }
}
