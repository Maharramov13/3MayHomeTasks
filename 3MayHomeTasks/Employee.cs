using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3MayHomeTasks
{
    internal class Employee:Human
    {
        public string Position { get; set; }

        public Employee(string name, string surname, int age, string position) : base(name, surname, age)
        {
            Position = position;
        }
    }
}
