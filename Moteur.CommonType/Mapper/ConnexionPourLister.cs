using Moteur.Domain.Entities;
using System;

namespace Moteur.CommonType.Mapper
{
    public class ConnexionPourLister
    {
        #region Propriétés
        /// <summary>
        /// Clé.
        /// </summary>
        public int Cle { get; set; }

        /// <summary>
        /// Date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Nom d'utilisateur.
        /// </summary>
        public string NomUtilisateur { get; set; }

        /// <summary>
        /// Nom du projet d'ou vien l'appel.
        /// </summary>
        public string NomProjet { get; set; }
        #endregion

        #region Méthodes static
        /// <summary>
        /// Convertie un objet Connexion en objet de présentation.
        /// </summary>
        /// <param name="connexion">Connexion à convertir</param>
        /// <returns>Connexion pour présentation.</returns>
        public static ConnexionPourLister Convertir(Connexion connexion)
        {
            return new ConnexionPourLister
            {
                Cle = connexion.Cle,
                Date = connexion.Date,
                NomProjet = connexion.NomProjet,
                NomUtilisateur = connexion.NomUtilisateur
            };
        }
        #endregion
    }
}
