using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CylindricalSocket
    {
        public string Supply(string cylinStem1, string cylinStem2)
        {
            return "Power power power...";
        }
    }

    public class RectangularAdapter : CylindricalSocket
    {
        public string Adapt(string rectaStem1, string rectaStem2, string rectStem3)
        {

            string cylinStem1 = rectaStem1;
            string cylinStem2 = rectaStem2;
            string Extrastrem3 = rectStem3;
            return Supply(cylinStem1, cylinStem2);
        }
    }

    public class RectangularPlug
    {
        private string rectaStem1;
        private string rectaStem2;
        private string rectaStem3;

        public void GetPower()
        {
            RectangularAdapter adapter = new RectangularAdapter();
            string power = adapter.Adapt(rectaStem1, rectaStem2, rectaStem3);
            Console.WriteLine(power);
        }
    }

}
