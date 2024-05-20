using MyLibrary;
namespace AccessModifiers
{
    internal class Program : MyMathSupport
    {
        public void Square(int x)
        {
            // only non-static method accesses the non-static inherited members
            Console.WriteLine("Inside square non-static method calling square method of parent");
            Square(x);
        }

        public void Cube(int x)
        {
            // only non-static method accesses the non-static inherited members
            Console.WriteLine("Inside Cube non-static method calling square method of parent");
            Cube(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Using Library MyLibrary and access Methods ---------------\n");
            // directly using inherited member
            Program program = new Program();
            program.Square(10);

            // method used by creating refernce 
            MyMathSupport myMathSupport = new MyMathSupport();
            myMathSupport.Square(10);

            //myMathSupport.cube(10);   not accessible using reference
            program.Cube(10);

            // static method sum can be called here directly
            Sum(10, 30, 40);
        }
    }
}
