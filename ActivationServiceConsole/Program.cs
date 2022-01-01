using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ActivationServiceConsole
{
    class Program
    {
        public static string VersionID = "1.0.0";
        public static string settingsPath = "";
        public static string path = Directory.GetCurrentDirectory();








        static void Main(string[] args)
        {


            Console.WriteLine($"ACTIVATION SERVICE V{VersionID}");

            Boolean findString(String baseString, String strinfToFind, String separator)
            {
                foreach (String str in baseString.Split(separator.ToCharArray()))
                {
                    if (str.Equals(strinfToFind))
                    {
                        return true;
                    }
                }
                return false;
            }


            void GenerateConfig()
            {


                settingsPath = $@"{path}\properties.env";
                File.Create(settingsPath).Close();
                using (StreamWriter writer = new StreamWriter($@"{path}\properties.env", true))
                {
                    writer.WriteLine($"version = {VersionID}");
                    writer.WriteLine($"---- KEYS ----");
                    writer.Close();
                }

            }
            if (!File.Exists($@"{path}\properties.env"))
            {

                Console.WriteLine("Warning: Hey! You don't have a properties file... Making one...");
                GenerateConfig();
            }
            else { settingsPath = $@"{path}\properties.env"; }
            if (File.ReadAllText(settingsPath).Length == 0)
            {
                Console.WriteLine("Warning: Hey! Your properties file is blank! Overwriting it.");
                File.Delete($@"{path}\properties.env");
                GenerateConfig();
            }

           

            if (!File.ReadAllText(settingsPath).Contains(VersionID))
            {

                Console.WriteLine("Your version is outdated!");
                //File.Delete($@"{path}\properties.env");
                // GenerateConfig();
               
            }

            Console.WriteLine("Enter a product key");

            var keys = File.ReadAllText(settingsPath);
            keys = keys.Replace($"version = {VersionID}", null);
            keys = keys.Replace($"---- KEYS ----", null);
            if (findString(keys, Console.ReadLine(), "")) { Console.WriteLine("Valid");
            

            
            } else { Console.WriteLine("Not Valid"); }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
