using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavouriteFood { get; set; }

        public Dog(string name, string type, int age, bool goodBoi, string favouriteFood) : base(name, type, age)
        {
            GoodBoi = goodBoi;
            FavouriteFood = favouriteFood;

        }
        public override string PrintInfo()
        {
            if (GoodBoi)
            {
                return $"{Name} is obedient, a give him a treat of {FavouriteFood}.";
            }
            else
            {
                return $"{Name} is not obedient, its not gonna have a treat of {FavouriteFood}!";
            }
        }

    }
}
