using Moteur.Domain.Entities;
using System;

namespace Moteur.CommonType.Mapper
{
    public class ConnexionPourDetail
    {
        #region Propriétés
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
        /// Convertie un objet de détail en objet Connexion.
        /// </summary>
        /// <param name="connexionPourDetail">Objet ConnexionPourDetail .</param>
        /// <returns>Connexion.</returns>
        public static Connexion Convertir(ConnexionPourDetail connexionPourDetail)
        {
            return new Connexion
            {
                NomProjet = connexionPourDetail.NomProjet,
            };
        }
        #endregion
    }
}
