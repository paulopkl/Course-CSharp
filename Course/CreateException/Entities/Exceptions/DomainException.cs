using System;

namespace Course.CreateException.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) {  }
    }
}
