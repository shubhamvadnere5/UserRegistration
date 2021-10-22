using System;
using System.Runtime.Serialization;

namespace UnitTestProject2
{
    [Serializable]
    internal class CustomException : Exception
    {
        internal string message;

        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}