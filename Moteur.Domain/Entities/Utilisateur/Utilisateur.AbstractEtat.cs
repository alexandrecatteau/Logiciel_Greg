using Extension.ExceptionTechnique;
using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utilisateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Domain.Entities.Utilisateur
{
    public abstract class UtilisateurAbstract<T> : IUtilisateurAbstractEtat where T : UtilisateurMachineEtat, new()
    {
        public EtatUtilisateur Etat { get; set; }
        public string ValeurEtat { get { return Etat.ToString(); } }

        public virtual void ChangerEtatVersAdmin(Utilisateur utilisateur)
        {
            throw new ExceptionTechnique($"Impossible de passer de l'état {this.ValeurEtat} à {EtatUtilisateur.Admin}.");
        }

        public virtual void ChangerEtatVersNA(Utilisateur utilisateur)
        {
            throw new ExceptionTechnique($"Impossible de passer de l'état {this.ValeurEtat} à {EtatUtilisateur.NA}.");
        }

        public virtual void ChangerEtatVersNormal(Utilisateur utilisateur)
        {
            throw new ExceptionTechnique($"Impossible de passer de l'état {this.ValeurEtat} à {EtatUtilisateur.Normal}.");
        }
    }
}
