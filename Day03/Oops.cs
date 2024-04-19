using System;
using System.Collections.Generic;
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
        public string firstname;

        public string lastname;

        public DateOnly birthday;
    }

    public class Person3(string firstname, string lastname, DateOnly birthday)
    {
        public string First { get; } = firstname;
        public String Last { get; } = lastname;
        public DateOnly Birthday { get; set; } = birthday;
        public List<Pet> Pets { get; } = new();

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

}
