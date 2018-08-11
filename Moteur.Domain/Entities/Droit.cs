using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Moteur.Domain.Entities
{
    /// <summary>
    /// Droits des utilisateurs.
    /// </summary>
    [Table("T_DRT")]
    public class Droit : DbContext
    {
        #region Attributs
        /// <summary>
        /// Cle du droit.
        /// </summary>
        [Column("CLE")]
        [Key]
        public int Cle { get; protected set; }

        /// <summary>
        /// Nom du droit.
        /// </summary>
        [Column("NOM")]
        public string Nom { get; set; }

        #endregion
    }
}
