using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities.Utlisateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moteur.Domain.Entities.Utilisateur
{
    public abstract class UtilisateurAbstract : IUtilisateur
    {
        public EtatUtlisateur Etat { get; private set; }

        public virtual string Test()
        {
            throw new Exception("test");
        }
    }
}
