using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utilisateur;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurNormal : UtilisateurAbstract<UtilisateurMachineEtat>
    {
        public UtilisateurNormal(Utilisateur utilisateur)
        {
            this.Etat = EtatUtilisateur.Normal;
        }

        public override void ChangerEtatVersAdmin(Utilisateur utilisateur)
        {
            utilisateur.Etat = (int)EtatUtilisateur.Admin;
        }

        public override void ChangerEtatVersNA(Utilisateur utilisateur)
        {
            utilisateur.Etat = (int)EtatUtilisateur.NA;
        }
    }
}
