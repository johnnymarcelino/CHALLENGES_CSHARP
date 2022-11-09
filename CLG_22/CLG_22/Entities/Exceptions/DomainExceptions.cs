using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_22.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
