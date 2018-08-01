using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension.Validateur
{
    public static partial class Validateur
    {
        /// <summary>
        /// Permet de valider un objet.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns>Retourne la variable.</returns>
        public static Objet.Validateur<T> Valider<T>(this T t, string nomParametre)
        {
            Objet.Validateur<T> validateur = new Objet.Validateur<T>
            {
                NomParametre = $"'{ObtenirNomParametre(nomParametre)}'",
                Valeur = t
            };

            if (t == null)
            {
                validateur.EstValide = false;
            }
            else
            {
                validateur.EstValide = true;
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si l'objet est nul.
        /// </summary>
        /// <returns>Retourne un objet Validateur.</returns>
        public static Objet.Validateur<T> NonNull<T>(this Objet.Validateur<T> validateur)
        {
            if (!validateur.EstValide)
            {
                throw new ArgumentNullException($"Le paramètre {validateur.NomParametre} ne peut pas être nul.", (Exception)null);
            }

            return validateur;
        }

        /// <summary>
        /// Récupération du nom du paramètre avec les espaces.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns></returns>
        private static string ObtenirNomParametre(string nomParametre)
        {
            List<char> listeCharParametre = nomParametre.ToCharArray().ToList();

            string retour = string.Empty;

            listeCharParametre.ForEach(x => retour += char.IsUpper(x) ? $" {x}" : x.ToString());

            return retour.First().ToString().ToUpper() + retour.Substring(1); ;
        }
    }
}
