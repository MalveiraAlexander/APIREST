using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Exceptions
{
    public class NotFoundException : ApiException
    {
        private static readonly string message = "The record not exist";

        public NotFoundException() : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
