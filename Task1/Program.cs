using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("------------------");

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (operation == '+')
        {
            result = num1 + num2;
        }
        else if (operation == '-')
        {
            result = num1 - num2;
        }
        else if (operation == '*')
        {
            result = num1 * num2;
        }
        else if (operation == '/')
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operation.");
            return;
        }

        Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
    }
}