using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Currency Converter");
        Console.WriteLine("==================");

        Console.Write("Enter amount in USD: ");
        double usdAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Select currency to convert to:");
        Console.WriteLine("1. Euro");
        Console.WriteLine("2. British Pound");
        Console.WriteLine("3. Indian Rupee");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        double convertedAmount = 0;
        switch (choice)
        {
            case 1:
                convertedAmount = usdAmount * 0.92; // 1 USD = 0.92 Euro
                Console.WriteLine($"Converted amount: {convertedAmount} Euro");
                break;
            case 2:
                convertedAmount = usdAmount * 0.79; // 1 USD = 0.79 British Pound
                Console.WriteLine($"Converted amount: {convertedAmount} British Pound");
                break;
            case 3:
                convertedAmount = usdAmount * 82.89; // 1 USD = 82.89 Indian Rupee
                Console.WriteLine($"Converted amount: {convertedAmount} Indian Rupee");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.ReadLine();
    }
}
