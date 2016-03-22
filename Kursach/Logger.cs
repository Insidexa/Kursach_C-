using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kursach
{
    class Logger
    {
        public static const string INFO = "INFO";
        public static const string ERROR = "ERROR";

        public static void log(string message, string type = "INFO")
        {
            string path = @"c:\temp\MyTest.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    sw.WriteLine("[" + type + "]: " + date + " => " + message);
                }
            }
            
        }
    }
}
