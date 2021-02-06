using System;

namespace SimpleTasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineA, lineB, lineC;
            Console.WriteLine("Please enter width of first line:");
            int.TryParse(Console.ReadLine(), out lineA);

            Console.WriteLine("Please enter width of first line:");
            int.TryParse(Console.ReadLine(), out lineB);

            Console.WriteLine("Please enter width of first line:");
            int.TryParse(Console.ReadLine(), out lineC);

            double square = triangelSquare(lineA, lineB, lineC);
            Console.WriteLine("Triangel Square: {0}", square);
        }

        static double triangelSquare(int lineA, int lineB, int lineC)
        {
            double parametr = (lineA + lineB + lineC) / 2;
            return Math.Sqrt(parametr * (parametr - lineA) * (parametr - lineB) * (parametr - lineC));
        }
    }
}
