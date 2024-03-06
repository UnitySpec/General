using System;
using System.Runtime.Serialization;

namespace UnityFlow.General.Errorhandling
{
    [Serializable]
    public class SpecFlowException : Exception
    {
        public SpecFlowException()
        {
        }

        public SpecFlowException(string message) : base(message)
        {
        }

        public SpecFlowException(string message, Exception inner) : base(message, inner)
        {
        }

        protected SpecFlowException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
