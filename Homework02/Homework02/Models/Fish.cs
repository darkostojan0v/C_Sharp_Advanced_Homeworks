using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public Fish(string name, string type, int age, string color, string size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Name} is a {Type} fish with a {Color} color, its a {Size} long and lives about {Age} years.";
        }
    }
}
