using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Moteur.Domain.Entities.Utilisateur
{
    /// <summary>
    /// Table des utilisateurs.
    /// </summary>
    [Table("T_UTL")]
    public class Utilisateur : DbContext
    {
        #region Attributs
        /// <summary>
        /// Clé de l'utilisateur.
        /// </summary>
        [Column("CLE")]
        [Key]
        public int Cle { get; set; }

        /// <summary>
        /// Nom de l'utilisateur.
        /// </summary>
        [Column("NOM")]
        [StringLength(100)]
        public string Nom { get; set; }

        /// <summary>
        /// Etat de l'utilisateur.
        /// </summary>
        [Column("ETAT")]
        public int Etat { get; set; }

        public ICollection<Connexion> Connexions { get; set; }
        #endregion

        #region Propriétés dynamiques
        /// <summary>
        /// Etat de l'utilisateur.
        /// </summary>
        public UtilisateurMachineEtat UtilisateurMachineEtat
        {
            get
            {
                return new UtilisateurMachineEtat(this);
            }
        }

        /// <summary>
        /// Indique si l'utilisateur est un admin.
        /// </summary>
        public bool EstAdmin
        {
            get
            {
                return (Enum.EtatUtilisateur)this.Etat == Enum.EtatUtilisateur.Admin;
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Utilisateur()
        {

        }
        #endregion
    }
}
