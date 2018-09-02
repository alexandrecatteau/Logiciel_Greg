using System.Data.Entity;

namespace Moteur.Domain.Entities
{
    /// <summary>
    /// Base de données.
    /// </summary>
    public class Entity : DbContext
    {
        /// <summary>
        /// Table des erreurs.
        /// </summary>
        public DbSet<Erreur> Erreurs { get; set; }

        /// <summary>
        /// Table des connexions
        /// </summary>
        public DbSet<Connexion> Connexions { get; set; }

        /// <summary>
        /// Table de paramétrage.
        /// </summary>
        public DbSet<Parametre> Parametres { get; set; }

        /// <summary>
        /// Table des utilisateurs.
        /// </summary>
        public DbSet<Utilisateur.Utilisateur> Utilisateurs { get; set; }

        public Entity()
            :base("Greg")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilisateur.Utilisateur>().HasIndex(e => e.Nom).IsUnique();
            modelBuilder.Entity<Connexion>().HasRequired<Utilisateur.Utilisateur>(x => x.Utilisateur).WithMany(x => x.Connexions).HasForeignKey<int>(x => x.CleUtilisateur);
            //modelBuilder.Entity<Connexion>().HasRequired(x=>x.)
        }
    }
}
