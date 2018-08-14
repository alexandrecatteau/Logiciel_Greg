using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using System.Collections.Generic;

namespace Moteur.Application.Interface.ServicesExterne
{
    public interface IWSMoteur
    {
        /// <summary>
        /// Récupération de toutes les connexions.
        /// </summary>
        /// <returns>Liste de connexion pour lister.</returns>
        List<Connexion> ObtenirListeConnexions();

        /// <summary>
        /// Enregistre une connexion.
        /// </summary>
        /// <param name="connexion">Connexion à enregistrer.</param>
        void AjouterConnexion(Connexion connexion);

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        void AjouterNouvelUtilisateur();

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utlisateur à ajouter.</param>
        void AjouterNouvelUtilisateur(Utilisateur utilisateur);

        /// <summary>
        /// Obtient la liste de tout les utilisateurs.
        /// </summary>
        /// <returns>Liste de tout le utilisateurs.</returns>
        List<Utilisateur> ObtenirListeUtilisateurs();
    }
}
