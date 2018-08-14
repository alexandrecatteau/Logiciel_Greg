using Moteur.Domain.Entities.Utilisateur;

namespace Moteur.Domain.Interfaces.Entities.Utlisateur
{
    public interface IUtilisateurAbstractEtat
    {
        /// <summary>
        /// Change un état vers Admin.
        /// </summary>
        /// <param name="utilisateur">Utlisateur à changer.</param>
        void ChangerEtatVersAdmin(Utilisateur utilisateur);

        /// <summary>
        /// Change un état vers normal.
        /// </summary>
        /// <param name="utilisateur">Utlisateur à changer.</param>
        void ChangerEtatVersNormal(Utilisateur utilisateur);

        /// <summary>
        /// Change un état vers NA.
        /// </summary>
        /// <param name="utilisateur">Utlisateur à changer.</param>
        void ChangerEtatVersNA(Utilisateur utilisateur);
    }
}
