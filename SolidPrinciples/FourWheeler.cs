using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class FourWheeler
    {
        public virtual void Start()
        {
            Console.WriteLine("Starting fourwheeler");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping fourwheeler");
        }
    }

    // Derived class representing a car, inheriting from FourWheeler
    class Car : FourWheeler
    {
        public override void Start()
        {
            Console.WriteLine("Doing something special to start the Car, as it's a Car");
            Console.WriteLine("Starting a Car");
        }

        public override void Stop()
        {
            Console.WriteLine("Doing something special to stop the Car, as it's a Car");
            Console.WriteLine("Stopping a Car");
        }
    }
}
