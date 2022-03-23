using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcVersion.Services.Exceptions
{
    public class IntegrityExceptions : ApplicationException
    {
        public IntegrityExceptions(string message) : base(message)
        {

        }
    }
}
