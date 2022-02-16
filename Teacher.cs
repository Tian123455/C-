using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01面向对象
{
    public class Teacher
    {
        public Teacher(string name)
        {
            this.Name = name;

        }
        public string Name
        {
            get;
            set;
        }
        public void SayHello()
        {
            Console.WriteLine("hello");
        }
    }
}
