using System;
using System.IO;

namespace SimpleTasks10
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"D:\test_file.txt";

            Console.WriteLine("Enter text yoou want to save, and press 'Enter':");
            string text = Console.ReadLine();

            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }
                Console.WriteLine("Write operation is done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Reading from file text you have entered:");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
