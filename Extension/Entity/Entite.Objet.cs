using System.Data.Entity;

namespace Extension.Entity
{
    public class Entite<T> where T : DbContext
    {
        public T EntiteValeur { get; set; }
    }
}
