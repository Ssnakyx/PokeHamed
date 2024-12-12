using Microsoft.EntityFrameworkCore;
using PokeBattle_Hamed.Model;

namespace PokeBattle_Hamed.Data
{
    public class PokemonDbContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Spell> Spells { get; set; }
 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string_here");
        }
    }
}
