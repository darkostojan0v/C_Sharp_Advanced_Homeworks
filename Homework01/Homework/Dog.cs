using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validate(Dog dog)
        {
            return dog.Id > 0 && dog.Name.Length >= 2 && dog.Color != string.Empty;
        }
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

    }
}
