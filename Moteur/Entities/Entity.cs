using System.Data.Entity;

namespace Moteur.Entities
{
    public class Entity : DbContext
    {
        public DbSet<Erreur> Erreurs { get; set; }

        public Entity()
            :base("GregTest")
        {

        }
    }
}
