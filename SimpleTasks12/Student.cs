using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks12
{
    class Student : IPerson
    {
        string _name;
        int _age;
        public string Course { get; set; }

        public Student(string name, int age, string course)
        {
            _name = name;
            _age = age;
            Course = course;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public override string ToString()
        {
            return $"IPerson is type of {typeof(Student)}" + $"{(this as IPerson).DiscribePerson()}, Course: {Course}";
        }
    }
}
