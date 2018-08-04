using System;

namespace Extension.Validateur
{
    public static partial class Validateur
    {
        /// <summary>
        /// Lève une exception si le paramètre est nul.
        /// </summary>
        /// <returns>Retourne un objet Validateur.</returns>
        public static Objet.Validateur<string> NonNul(this Objet.Validateur<string> validateur)
        {
            if (!validateur.EstValide)
            {
                var v = new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} ne peut pas être nul.");
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} ne peut pas être nul.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est nul, vide ou rempli d'espaces.
        /// </summary>
        /// <returns>Retourne un objet Validateur.</returns>
        public static Objet.Validateur<string> Obligatoire(this Objet.Validateur<string> validateur)
        {
            if (string.IsNullOrWhiteSpace(validateur.Valeur))
            {
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} doit être renseigné.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si la longueur du string est supérieur à la longueur maximale.
        /// </summary>
        /// <param name="longueurMaximale">Longueur Maximale.</param>
        /// <returns>Retourne un objet Validateur.</returns>
        public static Objet.Validateur<string> LongueurMaximale(this Objet.Validateur<string> validateur, int longueurMaximale)
        {
            if (validateur.Valeur.Length > longueurMaximale)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"La longueur maximale pour {validateur.NomParametre} est de '{longueurMaximale}'.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si la longueur du string est inférieur à la longueur minimale.
        /// </summary>
        /// <param name="longueurMinimale">Longueur Minimale.</param>
        /// <returns>Retourne un objet Validateur.</returns>
        public static Objet.Validateur<string> LongueurMinimale(this Objet.Validateur<string> validateur, int longueurMinimale)
        {
            if (validateur.Valeur.Length < longueurMinimale)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"La longueur minimale pour {validateur.NomParametre} est de '{longueurMinimale}'.");
            }

            return validateur;
        }
    }
}
