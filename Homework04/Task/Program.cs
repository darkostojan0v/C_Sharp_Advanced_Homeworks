using System;
using System.IO;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string absolutePath = currentDirectory;

            var theFolder = absolutePath + @"\Exercice\";

            if (!Directory.Exists(theFolder))
            {
                Console.WriteLine("The folder does not exist!");

                Directory.CreateDirectory(theFolder);

                Console.WriteLine($"The folder {theFolder} was created!");
            }

            string textFile = theFolder + "calculations.txt";

            if (!File.Exists(textFile))
            {
                Console.WriteLine("The file does not exits!");

                File.Create(textFile).Close();

                Console.WriteLine($"The file {textFile} was created!");
            }


            double input1;
            double input2;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sum the numbers");

                Console.Write("Write the first number: ");

                while(!double.TryParse(Console.ReadLine(), out input1))
                {
                    Console.WriteLine("Invalid input!");
                }

                Console.Write("Write the second number: ");

                while(!double.TryParse(Console.ReadLine(), out input2))
                {
                    Console.WriteLine("Invalid input!");
                }

                string result = Calculations.CalcSum(input1, input2);

                Console.WriteLine($"The result is {result}");

                DateTime localDate = DateTime.Now;

                string dateToString = localDate.ToString();

                Helper.TextInFile(textFile, result, dateToString);
            }

            using(StreamReader sr = new StreamReader(textFile))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}
