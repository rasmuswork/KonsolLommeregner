using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolLommeregner
{



    public class BananClass
    {
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Indtast bananer der skal konventeres.");
            ReadUserInput();

            WriteBanan(ConvertBanan());
            Console.ReadKey();
            Console.Clear();


        }
    }
}
