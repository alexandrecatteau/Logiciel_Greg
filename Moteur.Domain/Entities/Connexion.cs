using Extension.Validateur;
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
        /// Nom d'utilisateur.
        /// </summary>
        [Column("NOMUTILISATEUR")]
        public string NomUtilisateur { get; protected set; }

        /// <summary>
        /// Nom du projet d'ou vien l'appel.
        /// </summary>
        [Column("NOMPROJET")]
        public string NomProjet { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Connexion()
        {
            this.Date = DateTime.Now;
            this.NomUtilisateur = Environment.MachineName;
        }
        #endregion

        #region Méthode publiques
        /// <summary>
        /// Ajout d'un connexion dans la BDD.
        /// </summary>
        public void Ajouter()
        {

            using (var db = new Entity())
            {
                db.Connexions.Add(this);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Récupération d'une connexion avec un morceau du nom utilisateur.
        /// </summary>
        /// <param name="nom">String à rechercher.</param>
        /// <returns>Liste Connexion.</returns>
        public List<Connexion> ObtenirConnexionParNomUtilisateur(string nom)
        {
            nom.Valider(nameof(nom)).NonNul().Obligatoire();

            using (var db = new Entity())
            {
                return db.Connexions.Where(x => x.NomUtilisateur.Contains(nom)).ToList();
            }
        }

        /// <summary>
        /// Récupération des connexions supérieur à la date.
        /// </summary>
        /// <param name="date">Date Minimum.</param>
        /// <returns>Liste de connexions.</returns>
        public List<Connexion> ObtenirConnexionParDate(DateTime date)
        {
            date.Valider(nameof(date)).NonNull();

            using (var db = new Entity())
            {
                return db.Connexions.Where(x => x.Date > date).ToList();
            }
        }

        /// <summary>
        /// Obtient toutes les connexions.
        /// </summary>
        /// <returns>List de connexions</returns>
        public List<Connexion> ObtenirListeConnexion()
        {
            using (var db = new Entity())
            {
                return db.Connexions.ToList();
            }
        }
        #endregion
    }
}
