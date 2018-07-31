using System;
namespace Extension.Validateur
{
    public static partial class Validateur
    {
		/// <summary>
        /// Lève une exception si le paramètre est nul.
        /// </summary>
        /// <returns>Retourne la variable.</returns>
		public static string NonNul(this string s)
        {
            if (!_validateur.EstValide)
            {
                throw new ArgumentNullException($"Le paramètre {_validateur.NomParametre} ne peut pas être nul.", (Exception)null);
            }

            return s;
        }

		/// <summary>
        /// Lève une exception si le paramètre est nul, vide ou rempli d'espaces.
        /// </summary>
        /// <returns>Retourne la variable.</returns>
		public static string Obligatoire(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException($"Le paramètre {_validateur.NomParametre} doit être renseigné.", (Exception)null);
            }

            return s;
        }

		/// <summary>
        /// Lève une exception si la longueur du string est supérieur à la longueur maximale.
        /// </summary>
        /// <param name="longueurMaximale">Longueur Maximale.</param>
        /// <returns>Retourne la variable.</returns>
		public static string LongueurMaximale(this string s, int longueurMaximale)
        {
			if(s.Length > longueurMaximale)
            {
                throw new ArgumentOutOfRangeException($"La longueur maximale pour {_validateur.NomParametre} est de {longueurMaximale}.", (Exception)null);
            }

            return s;
        }

        /// <summary>
        /// Lève une exception si la longueur du string est inférieur à la longueur minimale.
        /// </summary>
        /// <param name="longueurMinimale">Longueur Minimale.</param>
        /// <returns>Retourne la variable.</returns>
        public static string LongueurMinimale(this string s , int longueurMinimale)
        {
            if (s.Length < longueurMinimale)
            {
                throw new ArgumentOutOfRangeException($"La longueur minimale pour {_validateur.NomParametre} est de {longueurMinimale}.", (Exception)null);
            }

            return s;
        }
    }
}
