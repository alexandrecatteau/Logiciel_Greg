using System.Data.Entity;

namespace Extension.Entities
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
