using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utlisateur;
using System;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurMachineEtat : IUtilisateurMachineEtat
    {
        #region Attributs
        public EtatUtlisateur EtatUtlisateur { get; set; }
        public string ValeurEtat { get { return this.EtatUtlisateur.ToString(); } }

        private UtilisateurAbstract<UtilisateurMachineEtat> _utilisateurAbstract;
        private Utilisateur _utilisateur;
        #endregion

        [Obsolete("Ne pas utiliser. Utliser le contructeur avec l'utilisateur en paramètre.")]
        public UtilisateurMachineEtat()
        {

        }

        public UtilisateurMachineEtat(Utilisateur utilisateur)
        {
            switch ((EtatUtlisateur)utilisateur.Etat)
            {
                case EtatUtlisateur.NA:
                    _utilisateurAbstract = new UtilisateurNA(utilisateur);
                    break;
                case EtatUtlisateur.Normal:
                    _utilisateurAbstract = new UtilisateurNormal(utilisateur);
                    break;
                case EtatUtlisateur.Admin:
                    _utilisateurAbstract = new UtilisateurAdmin(utilisateur);
                    break;
            }
            this._utilisateur = utilisateur;
            this.EtatUtlisateur = _utilisateurAbstract.Etat;
        }

        public void ChangerEtatVersAdmin()
        {
            _utilisateurAbstract.ChangerEtatVersAdmin(this._utilisateur);
        }

        public void ChangerEtatVersNA()
        {
            _utilisateurAbstract.ChangerEtatVersNA(this._utilisateur);
        }

        public void ChangerEtatVersNormal()
        {
            _utilisateurAbstract.ChangerEtatVersNormal(this._utilisateur);
        }
    }
}
