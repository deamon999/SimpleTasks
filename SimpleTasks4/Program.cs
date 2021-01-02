using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTasks4
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>(4);

            for (int i = 0; i < 4; i++)
            {
                int number;
                Console.WriteLine($"Please enter {i + 1} number:");
                string _number = Console.ReadLine();
                int.TryParse(_number, out number);

                if (number != 0)
                    numbers.Add(number);
            }

            int maxNumber = numbers.Max<int>();
            Console.WriteLine($"Max in entered numbres is: {maxNumber}");

        }
    }
}
