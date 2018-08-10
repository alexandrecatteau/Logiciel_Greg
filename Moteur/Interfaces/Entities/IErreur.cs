using Moteur.Domain.Entities;
using System.Collections.Generic;

namespace Moteur.Domain.Interfaces.Entities
{
    public interface IErreur
    {
        /// <summary>
        /// Ajout d'une erreur dans la BDD.
        /// </summary>
        /// <param name="erreur">Erreur à ajouter.</param>
        void Ajouter(Erreur erreur);

        /// <summary>
        /// Ajout d'une liste d'erreur dans la BDD.
        /// </summary>
        /// <param name="erreurs">Liste des erreurs à ajouter.</param>
        void Ajouter(List<Erreur> erreurs);

        /// <summary>
        /// Récupération d'une erreur par sa clé.
        /// </summary>
        /// <param name="cleErreur">Clé de l'erreur.</param>
        /// <returns>Erreur.</returns>
        Erreur ObtenirErreur(int cleErreur);

        /// <summary>
        /// Récupération des erreurs par une liste de clé.
        /// </summary>
        /// <param name="listeCleErreur">Liste des clés.</param>
        /// <returns>Liste des erreurs.</returns>
        List<Erreur> ObtenirListeErreurs(List<int> ListeCleErreur);
    }
}
