using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasks12
{
    class Manager : IPerson
    {
        string _name;
        int _age;
        public string Position { get; set; }

        public Manager(string name, int age, string position)
        {
            _name = name;
            _age = age;
            Position = position;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public override string ToString()
        {
            return $"IPerson is type of {typeof(Manager)}" + (this as IPerson).DiscribePerson() + $", Position: {Position}";
        }
    }
}
