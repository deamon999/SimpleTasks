using System;
using System.Collections.Generic;

namespace SimpleTasks12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> personList = new List<IPerson>();

            Student student = new Student("Niklas", 20, "Mathematics");
            personList.Add(student);

            Manager manager = new Manager("Alice", 35, "Electronics");
            personList.Add(manager);

            personList.ForEach(person => Console.WriteLine(person.ToString()));
        }
    }
}
