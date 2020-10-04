using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseVoice cat = new Cat();
            cat.Goes();

            BaseVoice dog = new Dog();
            dog.Goes();

            Console.ReadKey(); 
        }
    }
}
