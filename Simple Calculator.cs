using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator\n");

        while (true)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator (+, -, *, /):");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    continue;
            }

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Do you want to perform another calculation? (y/n)");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Calculator closed.");
    }
}
