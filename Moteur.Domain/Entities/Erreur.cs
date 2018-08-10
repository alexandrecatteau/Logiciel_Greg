using Extension.Validateur;
using Moteur.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Moteur.Domain.Entities
{
    /// <summary>
    /// Erreur.
    /// </summary>
    [Table("T_ERR")]
    public class Erreur : IErreur
    {
        #region Propriétés
        /// <summary>
        /// Clé de l'erreur.
        /// </summary>
        [Key]
        [Column("CLE")]
        public int Cle { get; protected set; }

        /// <summary>
        /// Date de l'erreur.
        /// </summary>
        [Column("DATE")]
        public DateTime Date { get; protected set; }

        /// <summary>
        /// Message de l'erreur.
        /// </summary>
        [Column("MESSAGE")]
        public string Message { get; set; }

        /// <summary>
        /// Chemin de l'erreur.
        /// </summary>
        [Column("STACKTRACE")]
        public string StackTrace { get; set; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message">Message de l'erreur.</param>
        /// <param name="stackTrace">Chemin de l'erreur.</param>
        public Erreur(string message, string stackTrace)
        {
            this.Date = DateTime.Now;
            this.Message = message;
            this.StackTrace = stackTrace;
        }

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        protected Erreur()
        {

        }
        #endregion

        #region Méthodes publiques
        /// <summary>
        /// Ajout d'une erreur dans la BDD.
        /// </summary>
        /// <param name="erreur">Erreur à ajouter.</param>
        public void Ajouter(Erreur erreur)
        {
            erreur.Valider(nameof(erreur)).NonNull();

            using (var db = new Entity())
            {
                db.Erreurs.Add(erreur);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Ajout d'une liste d'erreur dans la BDD.
        /// </summary>
        /// <param name="erreurs">Liste des erreurs à ajouter.</param>
        public void Ajouter(List<Erreur> erreurs)
        {
            erreurs.Valider(nameof(erreurs)).NonNull();
            using (var db = new Entity())
            {
                db.Erreurs.AddRange(erreurs);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Récupération d'une erreur par sa clé.
        /// </summary>
        /// <param name="cleErreur">Clé de l'erreur.</param>
        /// <returns>Erreur.</returns>
        public Erreur ObtenirErreur(int cleErreur)
        {
            cleErreur.Valider(nameof(cleErreur)).StrictementPositif();

            using (var db = new Entity())
            {
                return db.Erreurs.SingleOrDefault(x => x.Cle == cleErreur);
            }
        }

        /// <summary>
        /// Récupération des erreurs par une liste de clé.
        /// </summary>
        /// <param name="listeCleErreur">Liste des clés.</param>
        /// <returns>Liste des erreurs.</returns>
        public List<Erreur> ObtenirListeErreurs(List<int> listeCleErreur)
        {
            listeCleErreur.Valider(nameof(listeCleErreur)).NonNull();

            using (var db = new Entity())
            {
                List<Erreur> erreurs = new List<Erreur>();
                listeCleErreur.ForEach(x => erreurs.Add(db.Erreurs.SingleOrDefault(e => e.Cle == x)));

                return erreurs;
            }
        }
        #endregion
    }
}
