namespace Moteur.Domain.Interfaces.Entities.Utilisateur
{
    public interface IUtilisateurMachineEtat
    {
        /// <summary>
        /// Change un etat vers admin.
        /// </summary>
        void ChangerEtatVersAdmin();

        /// <summary>
        /// Change un état vers normal.
        /// </summary>
        void ChangerEtatVersNormal();

        /// <summary>
        /// Change un état vers NA.
        /// </summary>
        void ChangerEtatVersNA();
    }
}
