using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Cat : BaseVoice
    {
        public override void Goes()
        {
            Console.WriteLine("Cat goes meow \n");
        }
    }
}
