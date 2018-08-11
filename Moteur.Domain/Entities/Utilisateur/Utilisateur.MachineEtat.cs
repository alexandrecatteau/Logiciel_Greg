using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utlisateur;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurMachineEtat : IUtilisateur
    {
        private readonly UtilisateurAbstract Utilisateur;
        public EtatUtlisateur EtatUtlisateur { get; set; }
        public string ValeurEtat { get; set; }

        protected UtilisateurMachineEtat() { }

        public UtilisateurMachineEtat(EtatUtlisateur etat = EtatUtlisateur.NA)
        {
            this.EtatUtlisateur = etat;
            this.ValeurEtat = this.EtatUtlisateur.ToString();

            switch (this.EtatUtlisateur)
            {
                case EtatUtlisateur.NA:
                    this.Utilisateur = new UtilisateurNA();
                    break;
                case EtatUtlisateur.Normal:
                    this.Utilisateur = new UtilisateurNormal();
                    break;
                case EtatUtlisateur.Admin:
                    this.Utilisateur = new UtilisateurAdmin();
                    break;
                default:
                    break;
            }
        }

        public string Test()
        {
            return this.Utilisateur.Test();
        }
    }
}
