using System;

namespace SimpleTasks8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime lastMonthDate = today.AddMonths(-1);

            Console.WriteLine($"{today.Ticks - lastMonthDate.Ticks} milliseconds passed from the same date of previous month");

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Enter year:");
            string year = Console.ReadLine();

            Console.WriteLine("Enter month:");
            string month = Console.ReadLine();

            Console.WriteLine("Enter day:");
            string day = Console.ReadLine();

            DateTime now = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            Console.WriteLine($"You have entered this date: " + now.ToLongDateString());
        }
    }
}
