using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Cat : Animal
    {
        public Cat()
        {
            Legs = "4";
            Age = "2";
            Gender = "Female";
        }

        public void Sound()
        {
            Console.WriteLine("Meow\n");
        }
    }
}
