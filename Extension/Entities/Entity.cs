using System.Data.Entity;

namespace Extension.Entities
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
        
        public Entity()
            :base("GregTest")
        {

        }
    }
}
