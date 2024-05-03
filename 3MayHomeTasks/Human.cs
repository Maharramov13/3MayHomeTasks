using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3MayHomeTasks
{
    internal class Human
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        private int age { get; set; }

// private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age can not  under 0-");
                }
                else
                {
                    age = value;    
                }
            }
        }

        //public int MyAge
        //{
        //    get
        //    {
        //        return Age;
        //    }
        //    set
        //    {
        //            if (Age < 0)
        //            {
        //                Console.WriteLine("age can not be under 0");
        //            }
        //            else
        //            {
        //                Age = value;
        //            }

        //    }
        //}
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
