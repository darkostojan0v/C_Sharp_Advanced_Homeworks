using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public static class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            for (int i = 0; i < Dogs.Count; i++)
            {
                Console.WriteLine($"{Dogs[i].Name} is a {Dogs[i].Color} dog with an ID of {Dogs[i].Id}.");
            }
        }
    }
}
