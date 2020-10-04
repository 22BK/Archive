using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.WriteLine(dog.Age);
            Console.WriteLine(dog.Legs);
            Console.WriteLine(dog.Gender);
            dog.Sound();
            Console.WriteLine(cat.Age);
            Console.WriteLine(cat.Legs);
            Console.WriteLine(cat.Gender);
            cat.Sound();

            Console.ReadKey();
        }
    }
}
