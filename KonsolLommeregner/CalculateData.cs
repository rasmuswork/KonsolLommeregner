using System;

namespace KonsolLommeregner
{
    //Here is the methods for the calculations.
    public class CalculateData
    {
        public double TotalNumber { get; private set; }

        public void Subtract(double inputNumber)
        {
            TotalNumber -= inputNumber;
        }

        public void Addition(double inputNumber)
        {
            TotalNumber += inputNumber;
        }

        public void Multiplication(double inputNumber)
        {
            //as with the others it takes the operator and itself in one go
            TotalNumber *= inputNumber;
        }

        public void Division(double inputNumber)
        {
            if (inputNumber != 0)
            {
                TotalNumber /= inputNumber;
            }
            else
            {
                //Very simple error catching.
                Console.WriteLine("Cannot divide by zero.");
            }
        }


        public static void Circle()
        {

            const double Pi = 1 * (Math.PI); //Alias Shorthand

            Console.WriteLine("Write the value and what it is (Radius, Circumference, Area) write value first.");
            double Cvalue = Convert.ToDouble(Console.ReadLine());
            string Cproperty = Console.ReadLine() ?? "RADIUS";
            double Carea = 0;
            double Clength = 0;
            double Cradius = 0;
            if (Cproperty.ToUpper() == "RADIUS")
            { Cradius = Cvalue; Clength = (2 * Pi) * Cvalue; Carea = (Pi * (Cvalue * Cvalue)); }
            if (Cproperty.ToUpper() == "CIRCUMFERENCE")
            { Clength = Cvalue; Cradius = Clength / (2 * (Pi)); Carea = (Pi * (Cradius * Cradius)); }
            if (Cproperty.ToUpper() == "AREA")
            { Carea = Cvalue; Cradius = Math.Sqrt(Cvalue / Pi); Clength = (2 * Pi) * Cradius; }

            Console.WriteLine($"The radius is {Cradius}");
            Console.WriteLine($"The circumference is {Clength}");
            Console.WriteLine($"The area is {Carea}");
        }
    }
}