using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    public class Employee : IComparable
    {
        public string Name { get; set; }
        public float Salary { get; set; }

        public int CompareTo(object obj)
        {

            Employee temp = obj as Employee;
            if (temp != null)
            {
                //if (this.Salary > temp.Salary)
                //  return 1;
                //if (this.Salary < temp.Salary)
                //      return -1;
                //        else
                //  return 0;
                return this.Salary.CompareTo(temp.Salary);
            }
            else
                throw new ArgumentException("Parameter is not a employee!");
                // throw new NotImplementedException();

        }

        /*public int CompareTo(object obj)
        { 
        employee temp = obj as employee;
            if (temp != null)
            {
                return this.Name.CompareTo(temp.Name);
            }
            else
                throw new ArgumentException("Parameter is not a employee!");       
        
        }*/
    }

    //Icomparetor Strategy
    class Data_sort : IComparer
    {
        // Test the pet name of each object.
        public int Compare(object x, object y)
        {
            Employee t1 = x as Employee;
            Employee t2 = y as Employee;
            if (t1 != null && t2 != null)
                return String.Compare(t1.Name, t2.Name);
            else
                throw new ArgumentException("Parameter is not a Emp!");
        }
    }

    // IEnumerable Interface
    public class Company : IEnumerable
    {
        Employee[] e = new Employee[5];

        public Company()
        {
            e[0] = new Employee() { Name = "Raj", Salary = 50000 };
            e[1] = new Employee() { Name = "Anita", Salary = 80000 };
            e[2] = new Employee() { Name = "Mona", Salary = 30000 };
            e[3] = new Employee() { Name = "Geeta", Salary = 90000 };
            e[4] = new Employee() { Name = "Ravi", Salary = 70000 };
        }

        public IEnumerator GetEnumerator()
        {
            return e.GetEnumerator();
            //throw new NotImplementedException();
        }

    }

}
