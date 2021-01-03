using System;

namespace SimpleTasks7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ypu text and then press 'Enter'");

            string text = Console.ReadLine().Trim();
            string[] wordsArr = text.Split(" ");

            Console.WriteLine($"In text you have entered are {wordsArr.Length} words");
        }
    }
}
