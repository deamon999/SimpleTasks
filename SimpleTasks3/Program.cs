using System;

namespace SimpleTasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter circle radius");
            int radius;
            int.TryParse(Console.ReadLine(), out radius);

            Console.WriteLine($"Circle length is: {Math.PI * radius * 2}");
        }
    }
}
