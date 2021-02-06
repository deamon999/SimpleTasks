using System;

namespace SimpleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;
            const int STRING_LENGHT = 5;

            while (alive)
            {
                Console.WriteLine("Please enter 5 random digits:");
                string inputStr = Console.ReadLine();
                int result;

                if (!int.TryParse(inputStr, out result))
                {
                    Console.WriteLine("Input must be digits!");
                    continue;
                }

                if (inputStr.Length < STRING_LENGHT)
                {
                    Console.WriteLine("Input must containe 5 digits");
                    continue;
                }

                foreach (char c in inputStr.Substring(0, 5))
                {
                    Console.WriteLine(c);
                }

                Console.WriteLine("Do you want to continue, 'Enter' to continue, 'Esc' - to finish");
                ConsoleKeyInfo key = Console.ReadKey();

                if (ConsoleKey.Escape.Equals(key.Key))
                {
                    alive = false;
                }
            }
        }
    }
}
