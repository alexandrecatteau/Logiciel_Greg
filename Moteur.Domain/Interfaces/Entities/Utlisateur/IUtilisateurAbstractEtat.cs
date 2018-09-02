namespace Moteur.Domain.Interfaces.Entities.Utilisateur
{
    public interface IUtilisateurAbstractEtat
    {
        /// <summary>
        /// Change un état vers Admin.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à changer.</param>
        void ChangerEtatVersAdmin(Moteur.Domain.Entities.Utilisateur.Utilisateur utilisateur);

        /// <summary>
        /// Change un état vers normal.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à changer.</param>
        void ChangerEtatVersNormal(Moteur.Domain.Entities.Utilisateur.Utilisateur utilisateur);

        /// <summary>
        /// Change un état vers NA.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à changer.</param>
        void ChangerEtatVersNA(Moteur.Domain.Entities.Utilisateur.Utilisateur utilisateur);
    }
}
