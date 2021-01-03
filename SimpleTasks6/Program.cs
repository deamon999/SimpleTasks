using System;
using System.Linq;

namespace SimpleTasks6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[1000];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }

            Console.WriteLine("Enter the number you are searching:");
            string numberStr = Console.ReadLine();
            int searchedNumber;

            if (int.TryParse(numberStr, out searchedNumber))
            {
                Console.WriteLine($"Searched number is {searchedNumber}, index: {findNumber(arr, searchedNumber)}");
            }
            else
            {
                Console.WriteLine($"Wrong input string!");
            }
        }

        static int findNumber(int[] arr, int searchedNumber)
        {
            int defNumber = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (searchedNumber == arr[i])
                {
                    return i;
                }
            }
            return defNumber;
        }
    }
}
