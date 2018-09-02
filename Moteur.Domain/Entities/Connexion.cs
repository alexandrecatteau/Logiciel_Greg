using Extension.Validateur;
using Moteur.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Moteur.Domain.Entities
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
        public int Cle { get; protected set; }

        /// <summary>
        /// Date.
        /// </summary>
        [Column("DATE")]
        public DateTime Date { get; protected set; }

        /// <summary>
        /// Clé de l'utilisateur.
        ///// </summary>
        //[Column("UTILISATEUR")]
        //public Utilisateur.Utilisateur Utilisateur { get; set; }

        /// <summary>
        /// Nom du projet d'ou vien l'appel.
        /// </summary>
        [Column("NOMPROJET")]
        [StringLength(200)]
        public string NomProjet { get; set; }

        [Column("CLE_UTILISATEUR")]
        public int CleUtilisateur { get; set; }

        public Utilisateur.Utilisateur Utilisateur { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Connexion() { }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        /// <param name="utilisateur">Utilisateur ouvran la connexion
        public Connexion(string nomProjet)
        {
            nomProjet.Valider(nameof(nomProjet)).Obligatoire();

            this.NomProjet = nomProjet;
            this.Date = DateTime.Now;
        }
        #endregion

        
    }
}
