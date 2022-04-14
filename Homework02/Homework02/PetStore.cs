using Homework02.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework02
{
    public class PetStore<T> where T : Pet
    {
        public List<T> listOfPets = new List<T>();

        public PetStore()
        {
            listOfPets = new List<T>();
        }
        public void PrintsPets()
        {

            for (int i = 0; i < listOfPets.Count; i++)
            {
                if (listOfPets.Count == 0)
                {
                    Console.WriteLine("No pets available for adoption in the store");
                }
                else
                {
                    Console.WriteLine($"{i + 1}) {listOfPets[i].PrintInfo()}");
                }
            }
        }

        public void BuyPet(string name)
        {
            try
            {
                var pet = listOfPets.Single(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
                listOfPets.Remove(pet);
                Console.WriteLine($"{name} is ready for you!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"We don't have pet named {name}.");
            }
        }

        public void Add(T pet)
        {
            listOfPets.Add(pet);
        }


    }
}
