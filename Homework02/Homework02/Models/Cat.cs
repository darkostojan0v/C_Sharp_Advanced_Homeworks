using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int livesLeft) : base(name, type, age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }

        public override string PrintInfo()
        {
            if (Lazy)
            {
                return $"{Name} is a lazy cat, its a common for a {Type} cat.";
            }
            else
            {
                return $"{Name} has some energy, a tipical {Type} cat.";
            }
        }
    }
}
