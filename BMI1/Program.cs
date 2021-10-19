using System;

namespace BMI1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATION");

            Console.ReadLine();

            double Weight;
            double Height;
            double count;

            Console.WriteLine("Enter your Weight");
            double.TryParse(Console.ReadLine(), out Weight);
            Console.ReadLine();

            Console.WriteLine("Enter your Height");
            double.TryParse(Console.ReadLine(), out Height);
            Console.ReadLine();

            count = (Weight) / (Height/100*Height/100);

            Console.WriteLine();
            Console.WriteLine($"Your BMI is{ count }");
            Console.ReadLine();

        }
    }
}