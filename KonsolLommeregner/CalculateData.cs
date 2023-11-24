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
    }
}