using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolLommeregner
{



    public class BananClass
    {
        //Would be fun to add different types of banana lengths based on country of origin (Thai, Columbia, etc.)
        const double BananLength = 18.5;
        public double bananamount;


        public double ReadUserInput()
        {
            bananamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you for banana");
            Console.WriteLine("Press any button to return to the non banana part of the program");
            
            Console.ResetColor();
            return (double)bananamount;
            
        }

        public double ConvertBanan()
        {
            try
            {
                double totalbananlength = BananLength * bananamount;
                return totalbananlength;

            }

            catch
            {
                Console.WriteLine("Banan amount was too large! Setting return to zero");
                return 0;
            }
        }

        public void WriteBanan(double totalbananlength)
        {
            totalbananlength = ConvertBanan();
            Console.WriteLine($"{totalbananlength} cm.");

        }
        public void BananStart()
        {
            Console.Clear();
            //This is just for fun and might not work on other machines.(ASCII art)
            Console.WriteLine(" _\r\n//\\\r\nV  \\\r\n \\  \\_\r\n  \\,'.`-.\r\n   |\\ `. `.       \r\n   ( \\  `. `-.                        _,.-:\\\r\n    \\ \\   `.  `-._             __..--' ,-';/\r\n     \\ `.   `-.   `-..___..---'   _.--' ,'/\r\n      `. `.    `-._        __..--'    ,' /\r\n        `. `-_     ``--..''       _.-' ,'\r\n          `-_ `-.___        __,--'   ,'\r\n             `-.__  `----\"\"\"    __.-'\r\n                  `--..____..--'");
            Console.WriteLine("Banana has been successfully loaded.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please input the amount of bananas you want converted to centimeters(cm).");

            ReadUserInput();

            WriteBanan(ConvertBanan());
            Console.ReadKey();
            Console.Clear();


        }
    }
}
