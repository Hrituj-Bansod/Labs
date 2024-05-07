using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        private static Singleton uniqueInstance;

        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
        }

        public static Singleton GetSingleton()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();    // lazy manner
            }
            return uniqueInstance;
        }
    }
}
