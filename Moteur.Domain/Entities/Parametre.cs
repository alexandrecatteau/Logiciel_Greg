﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Moteur.Domain.Entities
{
    /// <summary>
    /// Table de paramétrage.
    /// </summary>
    [Table("T_PAR")]
    public class Parametre
    {
        #region Propriétés
        /// <summary>
        /// Clé.
        /// </summary>
        [Key]
        [Column("CLE")]
        public int Cle { get; protected set; }

        /// <summary>
        /// Nom.
        /// </summary>
        [Column("NOM")]
        public string Nom { get; set; }

        /// <summary>
        /// Valeur.
        /// </summary>
        [Column("VALEUR")]
        public string Valeur { get; set; }
        #endregion

        #region Propriétés dynamiques
        /// <summary>
        /// Indique si on est en debug.
        /// </summary>
        public bool EstDebug
        {
            get
            {
                using (var db = new Entity())
                {
                    return Convert.ToBoolean(int.Parse(db.Parametres.SingleOrDefault(x => x.Nom == "EstDebug").Valeur));
                }
            }
        }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        protected Parametre()
        {

        }
        #endregion
    }
}
