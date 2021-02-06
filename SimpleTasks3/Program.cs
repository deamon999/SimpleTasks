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

            if (radius == 0)
            {
                Console.WriteLine("Wrong data!");
            }
            else
            {
                Console.WriteLine($"Circle length is: {Math.PI * radius * 2}");
            }
        }
    }
}
