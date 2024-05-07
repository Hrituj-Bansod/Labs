using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPrinciples_DRY_KISS_YAGNI_
{
    class GFGCalc
    {
        public int CalcPow(int baseNum, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
