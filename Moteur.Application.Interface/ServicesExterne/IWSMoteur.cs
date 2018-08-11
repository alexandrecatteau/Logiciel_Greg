﻿using Moteur.CommonType.Mapper;
using Moteur.Domain.Entities;
using Moteur.Domain.Entities.Utilisateur;
using System.Collections.Generic;

namespace Moteur.Application.Interface.ServicesExterne
{
    public interface IWSMoteur
    {
        /// <summary>
        /// Récupération de toutes les connexions.
        /// </summary>
        /// <returns>Liste de connexion pour lister.</returns>
        List<ConnexionPourLister> ObtenirListeConnexions();

        /// <summary>
        /// Enregistre une connexion.
        /// </summary>
        /// <param name="connexion">Connexion à enregistrer.</param>
        void EnregistrerConnexion(ConnexionPourDetail connexion);

        /// <summary>
        /// Enregistrement d'un nouvel utilisateur.
        /// </summary>
        void EnregistrerNouvelUtilisateur();
    }
}
