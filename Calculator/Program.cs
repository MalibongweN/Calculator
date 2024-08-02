using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the application
            Console.WriteLine("Welcome to the Console Calculator!");

            try
            {
                // Prompt the user to enter the first number
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Prompt the user to enter the second number
                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Prompt the user to choose an operation
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("\t1. Addition (+)");
                Console.WriteLine("\t2. Subtraction (-)");
                Console.WriteLine("\t3. Multiplication (*)");
                Console.WriteLine("\t4. Division (/)");
                Console.Write("Enter your choice (1/2/3/4): ");
                string choice = Console.ReadLine();

                // Perform the selected operation
                double result = 0;
                bool validChoice = true;

                switch (choice)
                {
                    case "1":
                    case "+":
                        result = num1 + num2;
                        break;
                    case "2":
                    case "-":
                        result = num1 - num2;
                        break;
                    case "3":
                    case "*":
                        result = num1 * num2;
                        break;
                    case "4":
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validChoice = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please restart the application and choose a valid option.");
                        validChoice = false;
                        break;
                }

                // Display the result if the choice was valid
                if (validChoice)
                {
                    Console.WriteLine($"The result is: {result}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input, please enter numeric values.");
            }

            // End the application
            Console.WriteLine("Thank you for using the calculator. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
