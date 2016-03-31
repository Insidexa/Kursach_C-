using System;
using System.IO;

namespace Kursach
{
    class Logger
    {
        public const string INFO = "INFO";
        public const string ERROR = "ERROR";

        public static void log(string message, string type = "INFO")
        {
            string path = @"log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    sw.WriteLine("[" + type + "]: " + date + " => " + message);
                }
            }
        }
    }
}
