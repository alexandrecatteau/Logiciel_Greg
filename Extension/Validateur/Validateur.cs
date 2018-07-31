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
            _validateur = new Objet.Validateur { NomParametre = nomParametre };
            
            if (_validateur == null)
            {
               _validateur.EstValide = false;
            }
            else
            {
                _validateur.EstValide = true;
            }

            return t;
        }
    }
}
