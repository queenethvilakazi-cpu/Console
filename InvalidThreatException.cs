using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public class InvalidThreatException : Exception
    {
        public InvalidThreatException(string message) : base(message)
        {
        }
    }
}
