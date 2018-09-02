using Extension.Validateur;
using Moteur.Domain.Entities;
using Moteur.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Moteur.Domain.Repositories
{
    public class ConnexionRepository : IConnexionRepository
    {

        public ConnexionRepository()
        {
        }

        #region Méthode publiques
        /// <summary>
        /// Ajout d'un connexion dans la BDD.
        /// </summary>
        public void Ajouter(Connexion connexion)
        {
            using (var db = new Entity())
            {
                db.Connexions.Add(connexion);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Récupération d'une connexion avec un morceau du nom utilisateur.
        /// </summary>
        /// <param name="nom">String à rechercher.</param>
        /// <returns>Liste Connexion.</returns>
        public List<Connexion> ObtenirConnexionParNomUtilisateur(string nom)
        {
            nom.Valider(nameof(nom)).NonNul().Obligatoire();

            using (var db = new Entity())
            {
                //return db.Connexions.Where(x => x.Utilisateur.Nom.Contains(nom)).ToList();
                //TODO
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Récupération des connexions supérieur à la date.
        /// </summary>
        /// <param name="date">Date Minimum.</param>
        /// <returns>Liste de connexions.</returns>
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
            List<Connexion> connexions;
            using (var db = new Entity())
            {
                connexions = db.Connexions.ToList();
            }

            return connexions;
        }
        
        /// <summary>
        /// Obtient une connexion depuis une clé.
        /// </summary>
        /// <param name="cleConnexion">Clé de la connexion</param>
        /// <returns></returns>
        public Connexion ObtenirConnexionDepuisCle(int cleConnexion)
        {
            using (var db = new Entity())
            {
                return db.Connexions.SingleOrDefault(x => x.Cle == cleConnexion);
            }
        }


        /// <summary>
        /// Obtient une liste de connexion depuis une clé utilisateur.
        /// </summary>
        /// <param name="cleUtilisateur">Clé de l'utilisateur.</param>
        /// <returns>List des connexions.</returns>
        public List<Connexion> ObtenirListeConnexionDepuisCleUtilisateur(int cleUtilisateur)
        {
            using (var db= new Entity())
            {
                return db.Connexions.Where(x => x.CleUtilisateur == cleUtilisateur).OrderBy(x => x.Date).ToList();
            }
        }
        #endregion
    }
}
