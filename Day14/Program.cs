using System;
using System.Collections;
using System.Threading;

namespace Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Icloneable with Clone() abstract method
            Console.WriteLine("***** Fun with Object Cloning *****\n");
            Console.WriteLine("Cloned p3 and stored new Point in p4\n");
            Point p3 = new(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();  // Here clone method is called

            Console.WriteLine("Before modification:");
            Console.WriteLine("p3: {0}", p3);//100 100 Jane
            Console.WriteLine("p4: {0}", p4);//100 100 Jane
            Console.WriteLine("p3: {0}", p3.GetHashCode());
            Console.WriteLine("p4: {0}\n", p4.GetHashCode());

            p4.X = 99;
            p4.Y = 99;
            p4.desc.PetName = "hello";
            Console.WriteLine("After modification:");
            Console.WriteLine("p3: {0}", p3); //100 100 hello
            Console.WriteLine("p4: {0}", p4);//99 99 hello

            Console.ReadLine();


            //Icomparable with abstract method public int CompareTo(object obj)
            Console.WriteLine("Icomparable Interface : \n");
            Employee[] p = new Employee[5];
            p[0] = new Employee() { Name = "Raj", Salary = 50000 };
            p[1] = new Employee() { Name = "Anita", Salary = 80000 };
            p[2] = new Employee() { Name = "Mona", Salary = 30000 };
            p[3] = new Employee() { Name = "Geeta", Salary = 90000 };
            p[4] = new Employee() { Name = "Ravi", Salary = 70000 };
            Array.Sort(p);      // here sort method uses compareTo method to sort the elements 
            foreach (Employee employee in p)
                Console.WriteLine("{0}    {1}", employee.Salary, employee.Name);
            Console.ReadKey();
            Console.WriteLine();


            //Icomparer with abstract method public int Compare(object x, object y)
            Console.WriteLine("Icomparator Interface : \n");
            Array.Sort(p, new Data_sort());
            foreach (Employee employee in p)
                Console.WriteLine("{0}    {1}", employee.Salary, employee.Name);
            Console.ReadKey();


            //Ienumerable with abstract ,method GetEnumerator()

            Company cp = new Company();

            foreach (Employee ep in cp)
                Console.WriteLine(ep.Name);

            // Manually work with IEnumerator.
            IEnumerator i = cp.GetEnumerator();
            i.MoveNext();
            Employee emp = (Employee)i.Current;

            Console.WriteLine("{0} is getting sal of  rs{1} ", emp.Name, emp.Salary);


            while (i.MoveNext())
            {

                Employee myemp = (Employee)i.Current;

                Console.WriteLine("{0}  sal {1}", myemp.Name, myemp.Salary);
            }
            Console.ReadLine();

        }
    }
}
