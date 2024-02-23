using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1/2): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CelsiusToFahrenheit();
                break;
            case 2:
                FahrenheitToCelsius();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadLine();
    }

    static void CelsiusToFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }

    static void FahrenheitToCelsius()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {celsius}");
    }
}
