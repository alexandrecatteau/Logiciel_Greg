using Extension.Validateur;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Moteur.Entities
{
    /// <summary>
    /// table des connexions.
    /// </summary>
    [Table("T_CNX")]
    public class Connexion : DbContext
    {
        #region Propriétés
        /// <summary>
        /// Clé.
        /// </summary>
        [Key]
        [Column("CLE")]
        public int Cle { get; set; }

        /// <summary>
        /// Date.
        /// </summary>
        [Column("DATE")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Nom d'utilisateur.
        /// </summary>
        [Column("NOMUTILISATEUR")]
        public string NomUtilisateur { get; set; }

        /// <summary>
        /// Nom du projet d'ou vien l'appel.
        /// </summary>
        [Column("NOMPROJET")]
        public string NomProjet { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nomProjet"></param>
        public Connexion(string nomProjet)
        {
            this.NomUtilisateur = System.Environment.MachineName;
            this.Date = DateTime.Now;
            this.NomProjet = nomProjet;
        }
        #endregion
    }
}
