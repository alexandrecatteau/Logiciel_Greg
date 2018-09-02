using Moteur.Domain.Enum;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurAdmin : UtilisateurAbstract<UtilisateurMachineEtat>
    {
        public UtilisateurAdmin(Utilisateur utilisateur)
        {
            this.Etat = EtatUtilisateur.Admin;
        }
    }
}
