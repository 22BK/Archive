using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Dog : BaseVoice
    {
        public override void Goes()
        {
            Console.WriteLine("Dog goes hav hav \n");
        }
    }
}
