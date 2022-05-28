using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task
{
    public static class Helper
    {
        public static void AppendTextFile(string path, string json)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if(json == "break")
            {
                throw new Exception("Invalid");
            }

            sw.WriteLine(json);
            sw.Dispose();
        }
    }
}
