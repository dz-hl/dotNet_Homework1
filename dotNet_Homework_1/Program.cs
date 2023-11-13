using System;

namespace dotNet_Homework_1
{
    internal class Homework_1
    {
        static void Main(string[] args)
        {
            //Task 1

            int squareSide;
            Console.WriteLine("Define integer variable 'a' (side of the square).");
            while (!int.TryParse(Console.ReadLine(), out squareSide))
            {
                Console.WriteLine("Please, enter an integer value");
            }
            int squareArea = squareSide * squareSide;
            int squarePerimeter = squareSide + squareSide + squareSide + squareSide;
            Console.WriteLine("Area: " + squareArea + "\nPerimeter: " +  squarePerimeter);

            //Task 2

            Console.WriteLine("Please, enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello! Your name is {name} and you are {age} years old.");

            //Task 3

            if (!double.TryParse(Console.ReadLine(), out double circleRadius))
            {
                Console.WriteLine("Please, enter a double value");
            } else
            {
            double circleLength = 2 * Math.PI * circleRadius;
            double circleArea = Math.PI * circleRadius * circleRadius;
            double circleVolume = 4 / 3 * Math.PI * circleRadius * circleRadius * circleRadius;
            Console.WriteLine($"length: {circleLength}\narea: {circleArea}\nvolume: {circleVolume}");
            }
        }
    }
}
