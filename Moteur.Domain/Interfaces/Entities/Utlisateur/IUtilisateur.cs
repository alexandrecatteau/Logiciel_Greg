using Moteur.Domain.Entities.Utilisateur;
using System.Collections.Generic;

namespace Moteur.Domain.Interfaces.Entities.Utlisateur
{
    public interface IUtilisateur
    {
        /// <summary>
        /// Obtien un utilisateur par le nom.
        /// </summary>
        /// <param name="nom">Nom de l'utilisateur.</param>
        /// <returns>Utilisateur recherché.</returns>
        Utilisateur ObtenirUtlisateur(string nom);

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
        /// <param name="utlisateur">Utlisateur à ajouter.</param>
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
    }
}
