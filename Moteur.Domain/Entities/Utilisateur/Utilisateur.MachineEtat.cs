using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utlisateur;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurMachineEtat
    {
        #region Attributs
        /// <summary>
        /// Classe abstraite de l'utilisateur.
        /// </summary>
        private readonly UtilisateurAbstract Utilisateur;

        /// <summary>
        /// Etat de l'utilisateur.
        /// </summary>
        public EtatUtlisateur EtatUtlisateur { get; set; }

        /// <summary>
        /// Valeur en string de l'état.
        /// </summary>
        public string ValeurEtat { get; set; }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        protected UtilisateurMachineEtat() { }

        /// <summary>
        /// Constructeur pour gérer selon l'état.
        /// </summary>
        /// <param name="etat"></param>
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
        #endregion
    }
}
