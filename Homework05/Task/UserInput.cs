using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public static class UserInput
    {
        public static string Name()
        {
            Console.Write("Enter a name: ");

            string name = Console.ReadLine();

            while(name.Length <= 1)
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter a name: ");
            }

            return name;
        }

        public static int Age()
        {

            int age;

            Console.Write("Enter age: ");

            while(!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter age: ");
            }

            return age;
        }

        public static string Color()
        {
            Console.Write("Enter a color: ");

            string color = Console.ReadLine();

            while(color.Length == 0)
            {
                Console.WriteLine("Invalid input!");
                Console.Write("Enter a color: ");
            }

            return color;
        }
    }
}
