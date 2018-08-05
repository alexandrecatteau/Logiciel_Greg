﻿using Extension.Validateur;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Moteur.Entities
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
    }
}
