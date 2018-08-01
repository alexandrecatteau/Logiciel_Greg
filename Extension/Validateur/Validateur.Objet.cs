using System;

namespace Extension.Validateur.Objet
{
    /// <summary>
    /// Objet qui permet de valider un paramètre.
    /// </summary>
    public class Validateur<T>
    {
        /// <summary>
        /// Valeur de l'objet.
        /// </summary>
        internal T Valeur { get; set; }

        /// <summary>
        /// Nom du paramètre.
        /// </summary>
        internal string NomParametre { get; set; }

        /// <summary>
        /// Indique si le paramètre est valide.
        /// </summary>
        internal bool EstValide { get; set; }
    }
}
