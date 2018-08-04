using System;

namespace Extension.Validateur
{
    public static partial class Validateur
    {
        /// <summary>
        /// Lève une exception si le paramètre est inférieur à 0.
        /// </summary>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<long> Positif(this Objet.Validateur<long> validateur)
        {
            if (validateur.Valeur < 0)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} ne peut pas être inférieur à '0'.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est inférieur à 1.
        /// </summary>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<long> StrictementPositif(this Objet.Validateur<long> validateur)
        {
            if (validateur.Valeur < 1)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} doit être supérieur ou égal à '1'.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est supérieur à la valeur maximale.
        /// </summary>
        /// <param name="maximum">Valeur minimum.</param>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<long> Superieur(this Objet.Validateur<long> validateur, long maximum)
        {
            if (validateur.Valeur > maximum)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} doit être supérieur à '{maximum}'.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre est inférieur à la valeur minimale.
        /// </summary>
        /// <param name="minimum">Valeur minimale.</param>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<long> Inferieur(this Objet.Validateur<long> validateur, long minimum)
        {
            if (validateur.Valeur < minimum)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} doit être inférieur à '{minimum}'.");
            }

            return validateur;
        }

        /// <summary>
        /// Lève une exception si le paramètre n'est pas compris entre le minimum et le maximum.
        /// </summary>
        /// <param name="minimum">Valeur minimum.</param>
        /// <param name="maximum">Valeur maximum.</param>
        /// <returns>Retourne un objet Validateur</returns>
        public static Objet.Validateur<long> Entre(this Objet.Validateur<long> validateur, long minimum, long maximum)
        {
            if (validateur.Valeur < minimum || validateur.Valeur > maximum)
            {
                throw new ExceptionTechnique.ExceptionTechnique($"Le paramètre {validateur.NomParametre} doit être entre '{minimum}' et '{maximum}'.");
            }

            return validateur;
        }
    }
}
