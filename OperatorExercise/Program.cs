using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int addition = 2 + 2;
            int subtraction = 4 - 3;
            int multiplication = 2 * 3;

            Console.WriteLine($"{addition} {subtraction} {multiplication}");

            int a = 17;
            int b = 4;

            int division = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {division} remainder {remainder}");


            //Exercise 2

            Console.WriteLine("What is the radius of your circle");

            var radius = double.Parse(Console.ReadLine());

            double result = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {result}.");


        }

        public static double AreaOfCircle(double r)
        {
            double calculatedCircle = Math.PI * Math.Pow(r, 2);
            return calculatedCircle;
        }
    }
}
