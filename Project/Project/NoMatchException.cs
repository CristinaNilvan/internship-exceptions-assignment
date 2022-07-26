using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class NoMatchException : Exception
    {
        public NoMatchException()
        {

        }
        public NoMatchException(string message) : base(message)
        {

        }
    }
}
