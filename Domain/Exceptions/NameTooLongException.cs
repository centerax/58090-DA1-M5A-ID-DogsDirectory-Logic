using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    [Serializable]
    public class NameTooLongException : Exception
    {
        public NameTooLongException() { }
        public NameTooLongException(string message) : base(message) { }
        public NameTooLongException(string message, Exception inner) : base(message, inner) { }
        protected NameTooLongException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
