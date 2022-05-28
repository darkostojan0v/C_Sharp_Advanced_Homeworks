using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task
{
    public static class Helper
    {
        public static void TextInFile(string path, string result, string date)
        {
            StreamWriter sw = new StreamWriter(path, true);

            if(result == "break")
            {
                throw new Exception("Invalid!");
            }

            sw.WriteLine($"Date of calculation: {date} - Calculation: {result}");
            sw.Dispose();
        }
    }
}
