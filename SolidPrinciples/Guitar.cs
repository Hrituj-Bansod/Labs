using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class Guitar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Volume { get; set; }
    }

    public class SuperCoolGuitarWithFlames : Guitar
    {
        public string FlameColor { get; set; }

        // Constructor
        public SuperCoolGuitarWithFlames(string make, string model, int volume, string flameColor)
        {
            Make = make;
            Model = model;
            Volume = volume;
            FlameColor = flameColor;
        }

        // Display guitar details
        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Volume: {Volume}");
            Console.WriteLine($"Flame Color: {FlameColor}");
        }
    }
}
