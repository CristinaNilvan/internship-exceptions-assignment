using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DebugOperation
    {
        public static void Action(bool foundException)
        {
            Debug.WriteLineIf(foundException, "An exception has occured!");
        }
    }
}