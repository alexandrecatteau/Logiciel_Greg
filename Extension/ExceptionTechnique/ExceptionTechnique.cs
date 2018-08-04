using System;

namespace Extension.ExceptionTechnique
{
    public class ExceptionTechnique : Exception
    {
        public override string Message { get; }


        public ExceptionTechnique(string message)

        {
            this.Message = message;
        }
    }
}
