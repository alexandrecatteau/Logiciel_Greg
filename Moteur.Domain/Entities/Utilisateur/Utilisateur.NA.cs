using Extension.ExceptionTechnique;
using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utlisateur;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurNA : UtilisateurAbstract<UtilisateurMachineEtat>
    {
        public UtilisateurNA(Utilisateur utilisateur)
        {
            this.Etat = EtatUtlisateur.NA;
        }

        public override void ChangerEtatVersNormal(Utilisateur utilisateur)
        {
            utilisateur.Etat = (int)EtatUtlisateur.Normal;
        }
    }
}
