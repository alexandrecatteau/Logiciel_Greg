namespace Extension.Validateur.Objet
{
    /// <summary>
    /// Objet qui permet de valider un paramètre.
    /// </summary>
    internal class Validateur
    {
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
