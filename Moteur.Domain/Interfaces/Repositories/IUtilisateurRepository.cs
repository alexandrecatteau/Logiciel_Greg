using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using Moteur.Domain.Repositories;
using System.Collections.Generic;

namespace Moteur.Domain.Interfaces.Repositories
{
    public interface IUtilisateurRepository
    {
        /// <summary>
        /// Obtien un utilisateur par le nom.
        /// </summary>
        /// <param name="nom">Nom de l'utilisateur.</param>
        /// <returns>Utilisateur recherché.</returns>
        Utilisateur ObtenirUtilisateur(string nom);

        /// <summary>
        /// Détermine si il existe au moin un utilisateur.
        /// </summary>
        /// <returns></returns>
        bool EstTableVide();
        
        /// <summary>
        /// Récupération de tout les utilisateurs.
        /// </summary>
        /// <returns>Liste de tout les utilisateurs.</returns>
        List<Utilisateur> ObtenirListeUtilisateur();

        /// <summary>
        /// Ajout dun nouvel utilisateur dans la BDD.
        /// </summary>
        /// <param name="Utilisateur">Utilisateur à ajouter.</param>
        void Ajouter(Utilisateur utilisateur);

        /// <summary>
        /// Supprime un utilisateur par sa clé.
        /// </summary>
        /// <param name="cle">Clé à supprimer.</param>
        void Supprimer(int cle);

        /// <summary>
        /// Modifie un utilisateur par sa clé.
        /// </summary>
        ///<param name="utilisateur">Utilisateur qui a été modifié.</param>
        void Modifier(Utilisateur utilisateur);

        /// <summary>
        /// Ajout d'une nouvelle connexion pour un utilisateur
        /// </summary>
        /// <param name="utilisateur">Clé  de l'utilisateur ou ajouter la connexion.</param>
        /// <param name="connexion">Connexion à ajouter.</param>
        void AjouterConnexion(int cleUtilisateur, Connexion connexion);

        /// <summary>
        /// Obtient un utilisateur par sa clé.
        /// </summary>
        /// <param name="cle">Clé de l'utilisatuer.</param>
        /// <returns>Utilisateur recherché.</returns>
        Utilisateur ObtenirUtilisateurParCle(int cle);
    }
}
