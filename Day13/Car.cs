using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Car
    {
        public override string ToString() => GetType().Name;

        ~Car() => System.Diagnostics.Trace.WriteLine($"The {ToString()} finalizer is executing.");
    }

    public class Sedan : Car
    {
        public override string ToString() => GetType().Name;

        ~Sedan() => System.Diagnostics.Trace.WriteLine($"The {ToString()} finalizer is executing.");
    }

    public class Hondacity
    {
        public override string ToString() => GetType().Name;

        ~Hondacity() => System.Diagnostics.Trace.WriteLine($"The {ToString()} finalizer is executing.");
    }

}
