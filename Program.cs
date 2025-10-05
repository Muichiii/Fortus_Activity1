// See https://aka.ms/new-console-template for more information
//Fortus, Ralph Wendel M. BSCS 3-2

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SIMPLE CALCULATOR ===");

        // Ask for the first number
        Console.Write("\nEnter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Ask for the operator
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Ask for the second number
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool valid = true;

        // Perform calculation based on operator
        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("\nError: Cannot divide by zero!");
                valid = false;
            }
        }
        else
        {
            Console.WriteLine("\nInvalid operator!");
            valid = false;
        }

        // Print the result
        if (valid)
            Console.WriteLine($"\nResult: {result}");
    }
}
