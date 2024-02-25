using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. List Tasks");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Task Name:");
                    string taskName = Console.ReadLine();
                    tasks.Add(taskName);
                    break;
                case 2:
                    Console.WriteLine("Tasks:");
                    foreach (string task in tasks)
                    {
                        Console.WriteLine(task);
                    }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }
        }
    }
}
