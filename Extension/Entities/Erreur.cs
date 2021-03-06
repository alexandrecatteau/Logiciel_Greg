﻿using Extension.Validateur;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Extension.Entities
{
    /// <summary>
    /// Erreur.
    /// </summary>
    [Table("T_ERR")]
    public class Erreur
    {
        #region Propriétés
        /// <summary>
        /// Clé de l'erreur.
        /// </summary>
        [Key]
        [Column("CLE")]
        public int Cle { get; set; }

        /// <summary>
        /// Date de l'erreur.
        /// </summary>
        [Column("DATE")]
        public DateTime Date { get; set; }

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
        #endregion

        #region Méthodes publiques
        /// <summary>
        /// Ajout dans la base de données une erreur.
        /// </summary>
        public void Ajouter()
        {
            using (var db = new Entity())
            {
                db.Erreurs.Add(this);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Récupération de toutes les erreurs.
        /// </summary>
        /// <returns></returns>
        public List<Erreur> ObtenirErreurs()
        {
            using (var db = new Entity())
            {
                return db.Erreurs.ToList();
            }
        }
        #endregion
    }
}
