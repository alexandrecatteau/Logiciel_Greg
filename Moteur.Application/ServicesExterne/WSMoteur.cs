using Extension.Validateur;
using Moteur.Application.Interface.ServicesExterne;
using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Entities;
using Moteur.Domain.Interfaces.Entities.Utlisateur;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Moteur.Application.ServicesExterne
{
    /// <summary>
    /// Web Service pour le moteur.
    /// </summary>
    public class WSMoteur : IWSMoteur
    {
        /// <summary>
        /// Utilisateur.
        /// </summary>
        private IUtilisateur _utilisateur;

        /// <summary>
        /// Connexion.
        /// </summary>
        private IConnexion _connexion;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="nomProjet">Nom du projet.</param>
        public WSMoteur(string nomProjet)
        {
            nomProjet.Valider(nameof(nomProjet)).Obligatoire();

            _utilisateur = new Utilisateur();
            _connexion = new Connexion(nomProjet);
        }

        /// <summary>
        /// Récupération de toutes les connexions.
        /// </summary>
        /// <returns>Liste de connexion pour détail.</returns>
        public List<Connexion> ObtenirListeConnexions()
        {
            List<Connexion> connections = _connexion.ObtenirListeConnexion();

            return connections.ToList();
        }

        /// <summary>
        /// Enregistre une connexion.
        /// </summary>
        /// <param name="connexion">Connexion à enregistrer.</param>
        public void AjouterConnexion(Connexion connexion)
        {
            connexion.Valider(nameof(connexion)).NonNull();

            //On vérifie si il y a déjà un utilisateur avec le nom.
            if (!this.ObtenirListeUtilisateurs().Any(x=>x.Nom == connexion.NomUtilisateur))
            {
                this.AjouterNouvelUtilisateur(new Utilisateur {Nom = connexion.NomUtilisateur });
            }

            connexion.Ajouter();
        }
        
        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utlisateur à ajouter.</param>
        public void AjouterNouvelUtilisateur(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            _utilisateur.Ajouter(utilisateur);
        }

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        public void AjouterNouvelUtilisateur()
        {
            // Si la table est vide le 1er user est admin.
            if (_utilisateur.EstTableVide())
            {
                _utilisateur.Ajouter(new Utilisateur
                {
                    Nom = Environment.MachineName,
                    Etat = (int)EtatUtlisateur.Admin
                });
            }
            else
            {
                _utilisateur.Ajouter(new Utilisateur
                {
                    Nom = Environment.MachineName,
                    Etat = (int)EtatUtlisateur.NA
                });
            }
        }

        /// <summary>
        /// Obtient la liste de tout les utilisateurs.
        /// </summary>
        /// <returns>Liste de tout le utilisateurs.</returns>
        public List<Utilisateur> ObtenirListeUtilisateurs()
        {
            return _utilisateur.ObtenirListeUtilisateur();
        }
    }
}
