using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Calculator App!");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an operation: ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                }

                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (choice == "1")
                {
                    Console.WriteLine("Result: " + (num1 + num2));  
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Result: " + (num1 - num2));
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Result: " + (num1 * num2));
                }
                else if (choice == "4")
                {
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again!");
                }
            }
            Console.WriteLine();
        }
    }
}
