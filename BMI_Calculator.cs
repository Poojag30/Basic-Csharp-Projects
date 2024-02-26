using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");

            // Get user's weight in kilograms
            Console.Write("Enter your weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Get user's height in meters
            Console.Write("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            double bmi = weight / (height * height);

            // Display the result
            Console.WriteLine($"Your BMI is: {bmi}");

            // Interpret the result
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Normal weight");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

            Console.ReadLine(); 
        }
    }
}
