using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Dog : Animal
    {
        public Dog()
        {
            Legs = "4";
            Age = "6";
            Gender = "Male";
        }

        public void Sound()
        {
            Console.WriteLine("Woof\n");
        }
        
    }
}
