using System;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine("Enter your PIN:");
            string pin = Console.ReadLine();

            bool continueTransactions = true;
            while (continueTransactions)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Your balance is: $1000"); 
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to deposit:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Deposited {depositAmount}. Your new balance is: $1000");
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount to withdraw:");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        Console.WriteLine($"Withdrawn {withdrawAmount}. Your new balance is: $1000"); 
                        break;
                    case 4:
                        continueTransactions = false;
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
