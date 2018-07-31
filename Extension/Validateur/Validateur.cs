using System.Collections.Generic;
using System.Linq;

namespace Extension.Validateur
{
    public static partial class Validateur
    {
        private static Objet.Validateur _validateur;

        /// <summary>
        /// Permet de valider un objet.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        /// <returns>Retourne la variable.</returns>
        public static T Valider<T>(this T t, string nomParametre)
        {
            _validateur = new Objet.Validateur { NomParametre = $"'{ObtenirNomParametre(nomParametre)}'" };

            if (t == null)
            {
                _validateur.EstValide = false;
            }
            else
            {
                _validateur.EstValide = true;
            }

            return t;
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

            foreach (var item in listeCharParametre)
            {
                if (char.IsUpper(item))
                {
                    retour += $" {item}";
                }
                else
                {
                    retour += item;
                }
            }

            retour = retour.First().ToString().ToUpper() + retour.Substring(1);

            return retour;
        }
    }
}
