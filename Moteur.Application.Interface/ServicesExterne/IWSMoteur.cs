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
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        Utilisateur AjouterNouvelUtilisateur();

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à ajouter.</param>
        void AjouterUtilisateur(Utilisateur utilisateur);

        /// <summary>
        /// Obtient la liste de tout les utilisateurs.
        /// </summary>
        /// <returns>Liste de tout le utilisateurs.</returns>
        List<Utilisateur> ObtenirListeUtilisateurs();

        /// <summary>
        /// Obtien un utilisateur à partir du nom.
        /// </summary>
        /// <param name="nomUtilisateur">Nom de l'utilisateur.</param>
        /// <returns>Objet utilisateur.</returns>
        Utilisateur ObtenirUtilisateur(string nomUtilisateur);

        /// <summary>
        /// Ajoute une nouvelle connexion à un utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utilisateur ou ajouter la connexion.</param>
        /// <param name="nomProjet">Nomp du projet</param>
        void AjouterConnexion(Utilisateur utilisateur, string nomProjet);
    }
}
