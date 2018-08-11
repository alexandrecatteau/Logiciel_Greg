using System.ComponentModel;

namespace Moteur.Domain.Enum
{
    /// <summary>
    /// Etat de l'utilisateur.
    /// </summary>
    public enum EtatUtlisateur
    {
        /// <summary>
        /// Non défini.
        /// </summary>
        [Description("Non défini")]
        NA = 0,

        /// <summary>
        /// Normal.
        /// </summary>
        [Description("Normal")]
        Normal = 1,

        /// <summary>
        /// Admin.
        /// </summary>
        [Description("Admin")]
        Admin = 2
    }
}
