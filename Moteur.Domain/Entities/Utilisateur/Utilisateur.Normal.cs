using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utlisateur;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurNormal : UtilisateurAbstract<UtilisateurMachineEtat>
    {
        public UtilisateurNormal(Utilisateur utilisateur)
        {
            this.Etat = EtatUtlisateur.Normal;
        }

        public override void ChangerEtatVersAdmin(Utilisateur utilisateur)
        {
            utilisateur.Etat = (int)EtatUtlisateur.Admin;
        }

        public override void ChangerEtatVersNA(Utilisateur utilisateur)
        {
            utilisateur.Etat = (int)EtatUtlisateur.NA;
        }
    }
}
