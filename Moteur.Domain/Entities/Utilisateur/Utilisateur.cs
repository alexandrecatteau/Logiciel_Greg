using Extension.Validateur;
using Moteur.Domain.Interfaces.Entities.Utlisateur;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Moteur.Domain.Entities.Utilisateur
{
    /// <summary>
    /// Table des utilisateurs.
    /// </summary>
    [Table("T_UTL")]
    public class Utilisateur : DbContext, IUtilisateur
    {
        #region Attributs
        /// <summary>
        /// Clé de l'utilisateur.
        /// </summary>
        [Column("CLE")]
        [Key]
        public int Cle { get; set; }

        /// <summary>
        /// Nom de l'utilisateur.
        /// </summary>
        [Column("NOM")]
        public string Nom { get; set; }

        /// <summary>
        /// Etat de l'utilisateur.
        /// </summary>
        [Column("ETAT")]
        public int Etat { get; set; }
        #endregion

        #region Propriétés dynamiques
        /// <summary>
        /// Etat de l'utilisateur.
        /// </summary>
        public UtilisateurMachineEtat UtilisateurEtat
        {
            get
            {
                return new UtilisateurMachineEtat((Enum.EtatUtlisateur)this.Etat);
            }
        }

        /// <summary>
        /// Indique si l'utilisateur est un admin.
        /// </summary>
        public bool EstAdmin
        {
            get
            {
                return this.UtilisateurEtat.EtatUtlisateur == Enum.EtatUtlisateur.Admin;
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public Utilisateur()
        {

        }
        #endregion

        #region Méthodes publiques
        /// <summary>
        /// Obtien un utilisateur par le nom
        /// </summary>
        /// <param name="nom">Nom de l'utilisateur.</param>
        /// <returns>Utilisateur recherché.</returns>
        public Utilisateur ObtenirUtlisateur(string nom)
        {
            using (var db = new Entity())
            {
                return db.Utlisateurs.SingleOrDefault(x => x.Nom == nom);
            }
        }

        /// <summary>
        /// Détermine si il existe au moin un utilisateur.
        /// </summary>
        /// <returns></returns>
        public bool EstTableVide()
        {
            using (var db = new Entity())
            {
                return !(db.Utlisateurs.Count() > 0);
            }
        }

        /// <summary>
        /// Enregistrement d'un nouvelle utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à enregistrer.</param>
        public void EnregistrerUtilisateur(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur));
            utilisateur.Etat.Valider(nameof(utilisateur.Etat)).Positif();
            utilisateur.Nom.Valider(nameof(utilisateur.Nom)).Obligatoire();

            using (var db = new Entity())
            {
                db.Utlisateurs.Add(utilisateur);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
