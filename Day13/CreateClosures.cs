using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class ClosureExample
    {
        public Func<int, int> CreateClosure()
        {
            int x = 10;

            Func<int, int> increment = (y) =>
            {
                return x + y;
            };

            return increment;
        }
    }
}
