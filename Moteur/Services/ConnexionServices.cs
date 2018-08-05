using Extension.Validateur;
using Moteur.Entities;
using Moteur.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Moteur.Services
{
    /// <summary>
    /// Services pour gérer les connexions.
    /// </summary>
    public class ConnexionServices : IConnexionServices
    {
        #region Méthode publiques
        /// <summary>
        /// Ajout d'un connexion dans la BDD.
        /// </summary>
        /// <param name="connexion">Connexion.</param>
        public void Ajouter(Connexion connexion)
        {
            connexion.Valider(nameof(connexion)).NonNull();
            using (var db = new Entity())
            {
                db.Connexions.Add(connexion);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Récupération d'une connexion avec un morceau du non utilisateur.
        /// </summary>
        /// <param name="nom">String à rechercher.</param>
        /// <returns>Liste Connexion.</returns>
        public List<Connexion> ObtenirConnexionParNomUtilisateur(string nom)
        {
            nom.Valider(nameof(nom)).NonNul().Obligatoire();
            using (var db = new Entity())
            {
                return db.Connexions.Where(x => x.NomUtilisateur.Contains(nom)).ToList();
            }
        }

        /// <summary>
        /// Récupération des connexions supérieur à la date.
        /// </summary>
        /// <param name="date">DateMinimum.</param>
        /// <returns>Liste de connexion.</returns>
        public List<Connexion> ObtenirConnexionParDate(DateTime date)
        {
            date.Valider(nameof(date)).NonNull();
            using (var db = new Entity())
            {
                return db.Connexions.Where(x => x.Date > date).ToList();
            }
        }

        /// <summary>
        /// Obtient toutes les connexions.
        /// </summary>
        /// <returns>List de connexions</returns>
        public List<Connexion> ObtenirListeConnexion()
        {
            using (var db = new Entity())
            {
                return db.Connexions.ToList();
            }
        }
        #endregion
    }
}
