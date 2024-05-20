using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyLibrary
{
    public class MyMathLibrary
    {
        // Accessible anywhere inside this assembly or project(namespace) or outside the assembly
        public void Square(int x)
        {
            Print(x * x);
        }

        // Internal cannot be accessed outside only used for that reason
        internal protected void Cube(int x)
        {
            Cube(x * x * x);
        }

        // Accessible in same assembly in every class and outside in derived class 
        protected internal static void Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Print(sum);
        }

        // Accessible to ony derived classes in current and also outer assemblies
        protected void Half(int x)
        {
            Print(x / 2);
        }

        // Accessble only here inside this class
        private static void Print<T>(T parameter)
        {
            Console.WriteLine(parameter);
        }
    }

    public class MyMathSupport : MyMathLibrary
    {
        // Accessible only inside this assembly in every class not outside any class and not also in derived class outside this assembly
        internal void Cube(int x, int y, int z)
        {
            Console.WriteLine(x * y * z);
        }
    }

}
