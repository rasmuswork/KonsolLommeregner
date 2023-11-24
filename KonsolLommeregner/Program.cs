using KonsolLommeregner;

class Program
{
    static void Main(string[] args)
    {
        //this should clear the console when the user makes an error.
        Console.Clear();
        //Intiatiates the object.
        CalculateData calculator = new CalculateData();
        BananClass bananClass = new BananClass();
        


        //Depending on the console size this might not work. Forcing console window size only works on Windows sadly.
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║      Ultimate Console Calculater     ║");
        Console.WriteLine("╚══════════════════════════════════════╝");



        while (true)
        {

            Console.WriteLine("════════════════════════════════════════");
            Console.WriteLine($"           Current Total: {calculator.TotalNumber}");
            Console.WriteLine("════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a number or type 'exit' to quit:\n");
            Console.WriteLine("Options will be displayed after number input.");
            Console.ResetColor();
            string userInput = Console.ReadLine();
            Console.WriteLine("You entered " + userInput);

            //To lower ensures that it is not case sensitive
            if (userInput.ToLower() == "exit")
                break;

            //Tries to parse the userinput to a given double
            if (double.TryParse(userInput, out double number))
            {
                Console.Write("Enter an operation  + ,  - ,  * ,  /  \n");
                Console.WriteLine("You can also try: 'circle' or 'banan'");
                string operation = Console.ReadLine();

                //Switch case instead of if statements.
                switch (operation)
                {
                    case "+":
                        Console.WriteLine("You choice is addtition");
                        calculator.Addition(number);
                        Console.Clear();
                        break;
                    case "-":
                        Console.WriteLine("You choice is subtraction");
                        calculator.Subtract(number);
                        Console.Clear();
                        break;
                        
                    case "*":
                        Console.WriteLine("You choice is multiplication");
                        calculator.Multiplication(number);
                        Console.Clear();
                        break;
                    case "/":
                        Console.WriteLine("You choice is division");
                        calculator.Division(number);
                        Console.Clear();
                        break;

                    case "banan":
                        bananClass.BananStart();
                        break;

                    case "circle":
                        CalculateData.Circle();
                        break;

                    default:
                        //If user inputs anything that does not fit it will break with the given error message
                        Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                        break;
                }
            }
            else
            {
                //the while loop ensures that when the program "ends" it just loops around again.
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.WriteLine("You must enter an operator as a string and only the operator");
            }
        }
    }
}
