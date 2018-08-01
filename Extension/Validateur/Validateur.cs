﻿using System.Collections.Generic;
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

            return retour.First().ToString().ToUpper() + retour.Substring(1); ;
        }
    }
}
