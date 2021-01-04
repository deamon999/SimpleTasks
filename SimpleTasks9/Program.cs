using System;
using System.IO;

namespace SimpleTasks9
{
    class Program
    {
        static readonly string driveName = "D:\\";
        static void Main(string[] args)
        {

            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in driveInfos)
            {
                Console.WriteLine(driveInfo.Name);
                if (driveInfo.Name.StartsWith(driveName))
                {
                    Console.WriteLine($"Default selected drive, type: {driveInfo.DriveType}, free spaxe: {driveInfo.AvailableFreeSpace}, format: {driveInfo.DriveFormat}");
                }
            }

            Console.WriteLine("Enter catalogue name:");
            string catalogueName = Console.ReadLine().Trim();

            string directory = driveName + catalogueName;

            if (Directory.Exists(directory))
            {
                Console.WriteLine("Subdirectories:");
                string[] dirs = Directory.GetDirectories(directory);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Files:");
                string[] files = Directory.GetFiles(directory);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("There is no such directory!");
            }
        }
    }
}
