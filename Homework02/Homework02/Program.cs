using Homework02.Models;
using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Reks", "German Shepard", 5, true, "chicken");
            Dog dog2 = new Dog("Lola", "Poodle", 2, false, "bread");
            Dog dog3 = new Dog("Leon", "Sibirian Samoyed", 10, true, "bones");

            Cat cat1 = new Cat("Gigi", "Siamese", 1, true, 5);
            Cat cat2 = new Cat("Garfield", "Street cat", 3, false, 2);
            Cat cat3 = new Cat("Billy", "Angor", 7, true, 1);

            Fish fish1 = new Fish("Nemo", "Shark", 4, "white", "4m");
            Fish fish2 = new Fish("Golden", "Golden", 2, "gold", "10cm");
            Fish fish3 = new Fish("Dark", "Pirahna", 1, "black", "18cm");

            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.Add(dog1);
            dogStore.Add(dog2);
            dogStore.Add(dog3);
            
            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.Add(cat1);
            catStore.Add(cat2);
            catStore.Add(cat3);

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.Add(fish1);
            fishStore.Add(fish2);
            fishStore.Add(fish3);

            Console.WriteLine("Dogs of choice:");
            dogStore.PrintsPets();

            Console.WriteLine("Cats of choice:");
            catStore.PrintsPets();

            Console.WriteLine("Fish of choice:");
            fishStore.PrintsPets();

            Console.WriteLine("Choosing a dog...");
            dogStore.BuyPet("Leon");
            Console.WriteLine("Dogs left are:");
            dogStore.PrintsPets();

            Console.WriteLine("Choosing a cat...");
            catStore.BuyPet("Garfield");
            Console.WriteLine("Cats left are:");
            catStore.PrintsPets();

        }
    }
}
