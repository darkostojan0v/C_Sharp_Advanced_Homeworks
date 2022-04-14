using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }

        public abstract string PrintInfo();

        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}
