using Extension.Validateur;
using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using Moteur.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Moteur.Domain.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {

        public UtilisateurRepository()
        {
        }


        #region Méthodes publiques
        /// <summary>
        /// Obtien un utilisateur par le nom
        /// </summary>
        /// <param name="nom">Nom de l'utilisateur.</param>
        /// <returns>Utilisateur recherché.</returns>
        public Utilisateur ObtenirUtilisateur(string nom)
        {
            nom.Valider(nameof(nom)).NonNull();
            Utilisateur utilisateur;
            using (var db = new Entity())
            {
                utilisateur = db.Utilisateurs.SingleOrDefault(x => x.Nom == nom);
            }

            return utilisateur;
        }

        /// <summary>
        /// Détermine si il existe au moin un utilisateur.
        /// </summary>
        /// <returns></returns>
        public bool EstTableVide()
        {
            using (var db = new Entity())
            {
                return !(db.Utilisateurs.Count() > 0);
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
                return db.Utilisateurs.ToList();
            }
        }

        /// <summary>
        /// Ajout dun nouvel utilisateur dans la BDD.
        /// </summary>
        /// <param name="Utilisateur">Utilisateur à ajouter.</param>
        public void Ajouter(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            using (var db = new Entity())
            {
                db.Utilisateurs.Add(utilisateur);
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
                Utilisateur utilisateurSuppression = db.Utilisateurs.Single(x => x.Cle == cle);
                utilisateurSuppression.Valider(nameof(utilisateurSuppression)).NonNull();

                db.Utilisateurs.Remove(utilisateurSuppression);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Modifie un utilisateur.
        /// </summary>
        ///<param name="utilisateur">Utilisateur a modifié.</param>
        public void Modifier(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            utilisateur.Cle.Valider(nameof(utilisateur.Cle)).StrictementPositif();

            using (var db = new Entity())
            {
                Utilisateur utilisateurModifier = db.Utilisateurs.Single(x => x.Cle == utilisateur.Cle);
                utilisateurModifier.Valider(nameof(utilisateurModifier)).NonNull();

                db.Entry<Utilisateur>(utilisateurModifier).State = EntityState.Modified;
                db.Entry<Utilisateur>(utilisateurModifier).CurrentValues.SetValues(utilisateur);
            }
        }

        /// <summary>
        /// Ajout d'une nouvelle connexion pour un utilisateur
        /// </summary>
        /// <param name="utilisateur">Utilisateur ou ajouter la connexion.</param>
        /// <param name="utilisateur">Clé  de l'utilisateur ou ajouter la connexion.</param>
        public void AjouterConnexion(int cleUtilisateur, Connexion connexion)
        {
            connexion.Valider(nameof(connexion)).NonNull();

            using (var db = new Entity())
            {
                Utilisateur utilisateur = db.Utilisateurs.Single(x => x.Cle == cleUtilisateur);
                if (utilisateur.Connexions == null)
                {
                    utilisateur.Connexions = new List<Connexion>();
                }
                utilisateur.Connexions.Add(connexion);

                db.SaveChanges();
            }

        }

        /// <summary>
        /// Obtient un utilisateur par sa clé.
        /// </summary>
        /// <param name="cleUtilisateur">Clé de l'utilisatuer.</param>
        /// <returns>Utilisateur recherché.</returns>
        public Utilisateur ObtenirUtilisateurParCle(int cleUtilisateur)
        {
            cleUtilisateur.Valider(nameof(cleUtilisateur)).StrictementPositif();
            using (var db = new Entity())
            {
                return db.Utilisateurs.SingleOrDefault(x => x.Cle == cleUtilisateur);
            }
        }
        #endregion
    }
}
