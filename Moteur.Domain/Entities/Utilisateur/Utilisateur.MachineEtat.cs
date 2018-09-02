using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utilisateur;
using System;

namespace Moteur.Domain.Entities.Utilisateur
{
    public class UtilisateurMachineEtat : IUtilisateurMachineEtat
    {
        #region Attributs
        public EtatUtilisateur EtatUtilisateur { get; set; }
        public string ValeurEtat { get { return this.EtatUtilisateur.ToString(); } }

        private UtilisateurAbstract<UtilisateurMachineEtat> _utilisateurAbstract;
        private Utilisateur _utilisateur;
        #endregion

        [Obsolete("Ne pas utiliser. Utliser le contructeur avec l'utilisateur en paramètre.")]
        public UtilisateurMachineEtat()
        {

        }

        public UtilisateurMachineEtat(Utilisateur utilisateur)
        {
            switch ((EtatUtilisateur)utilisateur.Etat)
            {
                case EtatUtilisateur.NA:
                    _utilisateurAbstract = new UtilisateurNA(utilisateur);
                    break;
                case EtatUtilisateur.Normal:
                    _utilisateurAbstract = new UtilisateurNormal(utilisateur);
                    break;
                case EtatUtilisateur.Admin:
                    _utilisateurAbstract = new UtilisateurAdmin(utilisateur);
                    break;
            }
            this._utilisateur = utilisateur;
            this.EtatUtilisateur = _utilisateurAbstract.Etat;
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
