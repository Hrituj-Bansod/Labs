using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    // encapsulated or model using oops concept
    // class is a type or blueprint
    public class Person1
    {
        // constructor 
        public Person1(string first, string last, DateOnly bd) 
        {
            firstname = first;
            lastname = last;
            birthday = bd;
        }

        // member fields
        private string firstname;

        private string lastname;

        private DateOnly birthday;

    }

    public class Person2
    {
        // member fields
        public required string firstname;

        public string? lastname;

        public DateOnly birthday;
    }

    public class Person3(string firstname, string lastname, DateOnly birthday)
    {
        public string First { get; } = firstname;
        public String Last { get; } = lastname;
        public DateOnly Birthday { get; set; } = birthday;
        public List<Pet> Pets { get; } = [];

        public override string ToString()
        {
            return $"{First} {Last} ";
        }
    }

    // abstract and inheritance

    // base class pet is model of any class - design
    public abstract class Pet(string firstname)
    {
        // have some name 
        public string First { get; } = firstname;

        // make some noise
        public abstract string MakeNoise();

        public override string ToString()
        {
            return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
        }
    }


    public class Cat(string firstname) : Pet(firstname)
    { 
        // expression body functions
        public override string MakeNoise() => "meow";
    }


    public class Dog(string firstname) : Pet(firstname)
    {
        public override string MakeNoise() { return "bark"; }
    }


    // 1.Encapsulation 
    public class Player
    {
        private string name;

        public void SetName(string name)
        { this.name = name; }   

        public string GetName()
        {
            return name;
        }
    }

    public class BankAccount
    { 
        public decimal BankAmount { get; set; }
    }


    // 2. Inheritance 
    public class Person(string name)
    {
        public string Name { get; set; } = name;
        public void Sleeps()
        {
            Console.WriteLine(Name+" Sleeping .. ");
        }
    }
    public class Gamer(String name) : Person(name)
    { 
        public void Plays()
        {
            Console.WriteLine(Name+" Playing ..");
        }
    }

    // 3. Polymorphism 
    public class SportPerson(String name)
    {
        public string Name { get; set; } = name;
        public virtual void plays()
        {
            Console.WriteLine(Name+" plays");
        }
    }

    public class Cricketer(String name) : SportPerson(name)
    {
        public override void plays()
        {
            Console.WriteLine(Name + " bats");
        }
    }

    public class BrainAthlete(String name) : SportPerson(name)
    {
        public override void plays()
        {
            Console.WriteLine(Name + " thinks");
        }
    }

    // 4.Abstraction using interface

    public interface IFourWheeler
    {
        void Run();
    }

    public class Car : IFourWheeler
    { 
        public void Run()
        {
            Console.WriteLine("Car Runs ...");
        }
    }

    public class Bus : IFourWheeler
    { 
        public void Run()
        {
            Console.WriteLine("Bus Runs ...");
        }
    }

    // Abstraction using abstract class 
    public abstract class FourWheeler
    {
        public abstract void Run();
        public void Start()
        {
            Console.WriteLine("Four wheeler Starts ...");
        }
    }

    public class Car1 : FourWheeler
    {
        public override void Run()
        {
            Console.WriteLine("Car Runs ...");
        }
    }

    public class Bus1 : FourWheeler
    {
        public override void Run()
        {
            Console.WriteLine("Bus Runs ...");
        }
    }


}
