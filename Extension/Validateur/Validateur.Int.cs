using System;

namespace Extension.Validateur
{
    public static partial class Validateur
    {
        /// <summary>
        /// Lève une exception si le paramètre est inférieur à 0.
        /// </summary>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<int> Positif(this Objet.Validateur<int> validateur)
        {
            if (validateur.Valeur < 0)
            {
                throw new ArgumentOutOfRangeException($"Le paramètre {validateur.NomParametre} ne peut pas être inférieur à '0'.", (Exception)null);
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est inférieur à 1.
        /// </summary>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<int> StrictementPositif(this Objet.Validateur<int> validateur)
        {
            if(validateur.Valeur < 1)
            {
                throw new ArgumentOutOfRangeException($"Le paramètre {validateur.NomParametre} doit être supérieur ou égal à '1'.", (Exception)null);
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est supérieur à la valeur maximale.
        /// </summary>
        /// <param name="maximum">Valeur minimum.</param>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<int> Superieur(this Objet.Validateur<int> validateur, int maximum)
        {
            if(validateur.Valeur > maximum)
            {
                throw new ArgumentOutOfRangeException($"Le paramètre {validateur.NomParametre} doit être supérieur à '{maximum}'.", (Exception)null);
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est inférieur à la valeur minimale.
        /// </summary>
        /// <param name="minimum">Valeur minimale.</param>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<int> Inferieur(this Objet.Validateur<int> validateur, int minimum)
        {
            if(validateur.Valeur < minimum)
            {
                throw new ArgumentOutOfRangeException($"Le paramètre {validateur.NomParametre} doit être inférieur à '{minimum}'.", (Exception)null);
            }

            return validateur;
        }
        
        /// <summary>
        /// Lève une exception si le paramètre n'est pas compris entre le minimum et le maximum.
        /// </summary>
        /// <param name="minimum">Valeur minimum.</param>
        /// <param name="maximum">Valeur maximum.</param>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<int> Entre(this Objet.Validateur<int>  validateur, int minimum, int maximum)
        {
            if(validateur.Valeur < minimum || validateur.Valeur > maximum)
            {
                throw new ArgumentOutOfRangeException($"Le paramètre {validateur.NomParametre} doit être entre '{minimum}' et '{maximum}'.", (Exception)null);
            }

            return validateur;
        }
    }
}
