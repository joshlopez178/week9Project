using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9Project
{
    class Hawk: Bird, IFlightCapable
    {
        public void TakeFlight()
        {
            Console.WriteLine("This bird can fly!");
        }

    }
}
