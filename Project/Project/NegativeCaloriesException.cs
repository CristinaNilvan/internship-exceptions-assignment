using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class NegativeCaloriesException : Exception
    {
        public NegativeCaloriesException()
        {

        }

        public NegativeCaloriesException(string message) : base(message)
        {

        }
    }
}
