using System;
using System.Collections.Generic;

namespace Homework
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Dog dogOne = new Dog( 1, "Dark", "black" );
            Dog dogTwo = new Dog( 2, "Bela", "white" );
            Dog dogThree = new Dog( 3, "Leon", "gray" );

            Dog.Validate(dogOne);
            Dog.Validate(dogTwo);
            Dog.Validate(dogThree);

            DogShelter.Dogs.Add(dogOne);
            DogShelter.Dogs.Add(dogTwo);
            DogShelter.Dogs.Add(dogThree);

            DogShelter.PrintAll();

            dogOne.Bark();

            Console.ReadLine();
        }
    }
}
