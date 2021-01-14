//Joshua Lopez
//COSC 1320
//Week 9 Project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlightCapable> birds = new List<IFlightCapable>();
            birds.Add(new Hawk());
            birds.Add(new Eagle());

            FlyBird(birds);


            Console.ReadKey();
        }

        static void FlyBird(List<IFlightCapable> theBirds)
        {
            foreach (IFlightCapable bird in theBirds)
            {
                bird.TakeFlight();
            }
            
        }



    }
}
