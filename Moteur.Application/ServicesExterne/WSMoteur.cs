using Extension.Validateur;
using Moteur.Application.Interface.ServicesExterne;
using Moteur.CommonType.Mapper;
using Moteur.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Moteur.Application.ServicesExterne
{
    public class WSMoteur : IWSMoteur
    {
        /// <summary>
        /// Récupération de toutes les connexions.
        /// </summary>
        /// <returns>Liste de connexion pour détail.</returns>
        public List<ConnexionPourLister> ObtenirListeConnexions()
        {
            Connexion connexion = new Connexion();
            List<Connexion> connections = connexion.ObtenirListeConnexion();

            return connections.Select(x => ConnexionPourLister.Convertir(x)).ToList();
        }

        /// <summary>
        /// Enregistre une connexion.
        /// </summary>
        /// <param name="connexion">Connexion à enregistrer.</param>
        public void EnregistrerConnexion(ConnexionPourDetail connexionPourDetail)
        {
            connexionPourDetail.Valider(nameof(connexionPourDetail)).NonNull();

            Connexion connexion = ConnexionPourDetail.Convertir(connexionPourDetail);
            connexion.Ajouter();
        }
    }
}
