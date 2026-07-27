using System;

namespace CalculatorDotnet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Operations: +, -, *, /");

        try
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Enter operator (+, -, *, /): ");
            string? op = Console.ReadLine();

            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine() ?? string.Empty);

            double result = op switch
            {
                "+" => Calculator.Add(first, second),
                "-" => Calculator.Subtract(first, second),
                "*" => Calculator.Multiply(first, second),
                "/" => Calculator.Divide(first, second),
                _ => throw new InvalidOperationException("Invalid operator")
            };

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
