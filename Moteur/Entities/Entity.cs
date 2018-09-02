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
        public DbSet<Parametre> Parametre { get; set; }

        public Entity()
            :base("GregTest")
        {

        }
    }
}
