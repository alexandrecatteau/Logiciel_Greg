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
        public UtilisateurMachineEtat UtilisateurMachineEtat
        {
            get
            {
                return new UtilisateurMachineEtat(this);
            }
        }

        /// <summary>
        /// Indique si l'utilisateur est un admin.
        /// </summary>
        public bool EstAdmin
        {
            get
            {
                return (Enum.EtatUtlisateur)this.Etat == Enum.EtatUtlisateur.Admin;
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
        /// Récupération de tout les utilisateurs.
        /// </summary>
        /// <returns>Liste de tout les utilisateurs.</returns>
        public List<Utilisateur> ObtenirListeUtilisateur()
        {
            using (var db = new Entity())
            {
                return db.Utlisateurs.ToList();
            }
        }

        /// <summary>
        /// Ajout dun nouvel utilisateur dans la BDD.
        /// </summary>
        /// <param name="utlisateur">Utlisateur à ajouter.</param>
        public void Ajouter(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            using (var db = new Entity())
            {
                db.Utlisateurs.Add(utilisateur);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime un utilisateur par sa clé.
        /// </summary>
        /// <param name="cle">Clé à supprimer.</param>
        public void Supprimer(int cle)
        {
            cle.Valider(nameof(cle)).StrictementPositif();
            using (var db = new Entity())
            {
                Utilisateur utilisateurSuppression = db.Utlisateurs.Single(x => x.Cle == cle);
                utilisateurSuppression.Valider(nameof(utilisateurSuppression)).NonNull();

                db.Utlisateurs.Remove(utilisateurSuppression);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Modifie un utilisateur par sa clé.
        /// </summary>
        ///<param name="utilisateur">Utilisateur qui a été modifié.</param>
        public void Modifier(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            utilisateur.Cle.Valider(nameof(utilisateur.Cle)).StrictementPositif();

            using (var db = new Entity())
            {
                Utilisateur utilisateurModifier = db.Utlisateurs.Single(x => x.Cle == utilisateur.Cle);
                utilisateurModifier.Valider(nameof(utilisateurModifier)).NonNull();

                db.Entry<Utilisateur>(utilisateurModifier).State = EntityState.Modified;
                db.Entry<Utilisateur>(utilisateurModifier).CurrentValues.SetValues(utilisateur);
            }
        }
        #endregion
    }
}
