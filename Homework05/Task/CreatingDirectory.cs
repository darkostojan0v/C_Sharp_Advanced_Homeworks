using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task
{
    public static class CreatingDirectory
    {
        public static string CreatingFolder()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string apsolutePath = currentDirectory;

            var jsonFileFolder = apsolutePath + @"\JsonFiles\";

            if (!Directory.Exists(jsonFileFolder))
            {
                Directory.CreateDirectory(jsonFileFolder);
            }

            return jsonFileFolder;
        }

        public static string CreatingFile(string path)
        {
            string jsonFile = path + "json.json";

            if (!File.Exists(jsonFile))
            {
                File.Create(jsonFile).Close();
            }

            return jsonFile;
        }
    }
}
