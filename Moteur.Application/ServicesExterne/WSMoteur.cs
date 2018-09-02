using Extension.Validateur;
using Moteur.Application.Interface.ServicesExterne;
using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using Moteur.Domain.Enum;
using Moteur.Domain.Interfaces.Repositories;
using Moteur.Domain.Repositories;
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
        private IUtilisateurRepository _utilisateur;

        /// <summary>
        /// Connexion.
        /// </summary>
        private IConnexionRepository _connexion;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public WSMoteur()
        {
            _utilisateur = new UtilisateurRepository();
            _connexion = new ConnexionRepository();
        }

        /// <summary>
        /// Récupération de toutes les connexions.
        /// </summary>
        /// <returns>Liste de connexion pour détail.</returns>
        public List<Connexion> ObtenirListeConnexions()
        {
            List<Connexion> connections = _connexion.ObtenirListeConnexion();
            connections.ForEach(x => x.Utilisateur = _utilisateur.ObtenirUtilisateurParCle(x.CleUtilisateur));

            return connections.ToList();
        }

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utilisateur à ajouter.</param>
        public void AjouterUtilisateur(Utilisateur utilisateur)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            _utilisateur.Ajouter(utilisateur);
        }

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        public Utilisateur AjouterNouvelUtilisateur()
        {
            Utilisateur nouvelUtilisateur;

            // Si la table est vide le 1er user est admin.
            if (_utilisateur.EstTableVide())
            {
                nouvelUtilisateur = new Utilisateur
                {
                    Nom = Environment.MachineName,
                    Etat = (int)EtatUtilisateur.Admin
                };
            }
            else
            {
                nouvelUtilisateur = new Utilisateur
                {
                    Nom = Environment.MachineName,
                    Etat = (int)EtatUtilisateur.NA
                };
            }

            _utilisateur.Ajouter(nouvelUtilisateur);
            return nouvelUtilisateur;
        }

        /// <summary>
        /// Obtient la liste de tout les utilisateurs.
        /// </summary>
        /// <returns>Liste de tout le utilisateurs.</returns>
        public List<Utilisateur> ObtenirListeUtilisateurs()
        {
            List<Utilisateur> utilisateurs = _utilisateur.ObtenirListeUtilisateur();

            utilisateurs.ForEach(x => x.Connexions = _connexion.ObtenirListeConnexionDepuisCleUtilisateur(x.Cle));

            return utilisateurs;
        }

        /// <summary>
        /// Obtien un utilisateur à partir du nom.
        /// </summary>
        /// <param name="nomUtilisateur">Nom de l'utilisateur.</param>
        /// <returns>Objet utilisateur.</returns>
        public Utilisateur ObtenirUtilisateur(string nomUtilisateur)
        {
            nomUtilisateur.Valider(nameof(nomUtilisateur)).Obligatoire();

            Utilisateur utilisateur = _utilisateur.ObtenirUtilisateur(nomUtilisateur);

            utilisateur.Connexions = _connexion.ObtenirListeConnexionDepuisCleUtilisateur(utilisateur.Cle);

            return utilisateur;
        }


        /// <summary>
        /// Ajoute une nouvelle connexion à un utilisateur.
        /// </summary>
        /// <param name="utilisateur">Utilisateur ou ajouter la connexion.</param>
        /// <param name="nomProjet">Nomp du projet</param>
        public void AjouterConnexion(Utilisateur utilisateur, string nomProjet)
        {
            utilisateur.Valider(nameof(utilisateur)).NonNull();
            utilisateur.Cle.Valider(nameof(utilisateur.Cle)).StrictementPositif();
            nomProjet.Valider(nameof(nomProjet)).Obligatoire();

            _utilisateur.AjouterConnexion(utilisateur.Cle, new Connexion(nomProjet));
        }
    }
}
