using Moteur.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Moteur.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface ConnectionServices.
    /// </summary>
    public interface IConnexionRepository
    {
        /// <summary>
        /// Ajout d'un connexion dans la BDD.
        /// </summary>
        void Ajouter(Connexion connexion);

        /// <summary>
        /// Récupération d'une connexion avec un morceau du non utilisateur.
        /// </summary>
        /// <param name="nom">String à rechercher.</param>
        /// <returns>Liste Connexion.</returns>
        List<Connexion> ObtenirConnexionParNomUtilisateur(string nom);

        /// <summary>
        /// Récupération des connexions supérieur à la date.
        /// </summary>
        /// <param name="date">DateMinimum.</param>
        /// <returns>Liste de connexion.</returns>
        List<Connexion> ObtenirConnexionParDate(DateTime date);

        /// <summary>
        /// Obtient toutes les connexions.
        /// </summary>
        /// <returns>List de connexions</returns>
        List<Connexion> ObtenirListeConnexion();

        /// <summary>
        /// Obtient une connexion depuis une clé.
        /// </summary>
        /// <param name="cleConnexion">Clé de la connexion</param>
        /// <returns></returns>
        Connexion ObtenirConnexionDepuisCle(int cleConnexion);

        /// <summary>
        /// Obtient une liste de connexion depuis une clé utilisateur.
        /// </summary>
        /// <param name="cleUtilisateur">Clé de l'utilisateur.</param>
        /// <returns>List des connexions.</returns>
        List<Connexion> ObtenirListeConnexionDepuisCleUtilisateur(int cleUtilisateur);
    }
}
