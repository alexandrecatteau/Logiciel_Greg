using Moteur.Entities;
using System;
using System.Collections.Generic;

namespace Moteur.Interfaces.Services
{
    /// <summary>
    /// Interface ConnectionServices.
    /// </summary>
    public interface IConnexionServices
    {
        /// <summary>
        /// Ajout d'un connexion dans la BDD.
        /// </summary>
        /// <param name="connexion">Connexion.</param>
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
    }
}
