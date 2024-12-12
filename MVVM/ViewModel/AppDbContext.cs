using Microsoft.EntityFrameworkCore;

namespace PokeBattle_Hamed.Model
{
    public partial class AppDbContext : DbContext
    {
        // Constructeur qui utilise les options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Déclaration des DbSet pour vos tables
        public DbSet<Login> Logins { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;

        // Configuration du modèle
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration de la table Login
            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Id); // Définir la clé primaire
                entity.Property(e => e.Username).IsRequired().HasMaxLength(100); // Champ obligatoire avec une taille max
                entity.Property(e => e.PasswordHash).IsRequired(); // Champ obligatoire
            });

            // Configuration de la table Player (ajoutez des configurations si nécessaire)

            base.OnModelCreating(modelBuilder);
        }
    }
}
