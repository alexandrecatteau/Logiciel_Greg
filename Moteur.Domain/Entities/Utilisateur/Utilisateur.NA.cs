using Extension.ExceptionTechnique;
using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utilisateur;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurNA : UtilisateurAbstract<UtilisateurMachineEtat>
    {
        public UtilisateurNA(Utilisateur utilisateur)
        {
            this.Etat = EtatUtilisateur.NA;
        }

        public override void ChangerEtatVersNormal(Utilisateur utilisateur)
        {
            utilisateur.Etat = (int)EtatUtilisateur.Normal;
        }
    }
}
