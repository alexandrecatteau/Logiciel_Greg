using Moteur.Domain.Entities.Utilisateur;

namespace Moteur.Domain.Interfaces.Entities.Utlisateur
{
    public interface IUtilisateur
    {
        /// <summary>
        /// Obtien un utilisateur par le nom
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
        /// Enregistrement d'un nouvelle utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à enregistrer.</param>
        void EnregistrerUtilisateur(Utilisateur utilisateur);
    }
}
