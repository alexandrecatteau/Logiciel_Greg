using Extension.Entities;
using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Extension.ExceptionTechnique
{
    public class ExceptionTechnique : Exception
    {
        public override string Message { get; }

        public override string StackTrace { get; }

        public ExceptionTechnique(string message)
            : base(message)
        {
            StackTrace st = new StackTrace(true);
            this.StackTrace = string.Empty;

            for (int i = 0; i < st.FrameCount; i++)
            {
                StackFrame sf = st.GetFrame(i);
                
                this.StackTrace += 
                    $"{sf.GetMethod().ToString()} à {sf.GetFileName()} ligne : {sf.GetFileLineNumber()} {Environment.NewLine}";
            }
            this.Message = message;

            Erreur erreur = new Erreur(this.Message, this.StackTrace);

            erreur.Ajouter();
        }
    }
}
