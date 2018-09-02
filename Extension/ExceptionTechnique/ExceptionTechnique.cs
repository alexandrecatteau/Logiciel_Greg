using Extension.Entities;
using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Extension.ExceptionTechnique
{
    /// <summary>
    /// Exception utilisé dans le Moteur.Domain.
    /// </summary>
    [SerializableAttribute]
    public class ExceptionTechnique : Exception
    {
        #region Propriétés
        /// <summary>
        /// Message d'information de l'exception.
        /// </summary>
        public string MessageExeption { get; }

        /// <summary>
        /// Chemin de l'exception.
        /// </summary>
        public string StackTraceExeption { get; }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="message"></param>
        public ExceptionTechnique(string message)
        {
            StackTrace st = new StackTrace(true);
            this.StackTraceExeption = string.Empty;

            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame sf = st.GetFrame(i);
                
                this.StackTraceExeption += 
                    $"{sf.GetMethod().ToString()} à {sf.GetFileName()} ligne : {sf.GetFileLineNumber()} {Environment.NewLine}";
            }
            this.MessageExeption = message;

            Erreur erreur = new Erreur(this.MessageExeption, this.StackTraceExeption);

            erreur.Ajouter();
        }
        #endregion
    }
}
