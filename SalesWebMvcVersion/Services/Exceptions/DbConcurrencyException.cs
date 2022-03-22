using System;
namespace SalesWebMvcVersion.Services.Exceptions
{
    public class DbConcurrencyException:ApplicationException
    {
        public DbConcurrencyException(string message):base(message)
        {

        }
    }
}
