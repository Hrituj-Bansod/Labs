using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
   
    public class Mutliprogramming
    {
            public static void Method1()
            {
                Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Method1 :" + i);
                }
                Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
            }

            public static void Method2()
            {
                Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Method2 :" + i);
                    if (i == 3)
                    {
                        Console.WriteLine("Performing the Database Operation Started");
                        //Sleep for 10 seconds
                        Thread.Sleep(10000);
                        Console.WriteLine("Performing the Database Operation Completed");
                    }
                }
                Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
            }
            public static void Method3()
            {
                Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Method3 :" + i);
                }
                Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
            }
    }

    // Encapsulating the input and method inside class 
    public class NumberHelper
    {
        int _Number;

        public NumberHelper(int Number)
        {
            _Number = Number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _Number; i++)
            {
                Console.WriteLine("value : " + i);
            }
        }
    }

}
