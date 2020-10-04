using System;

namespace OOP.OopDescriptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1; 

            while (counter <= 4)
            {
                Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

                string principleCode;

                Console.WriteLine("OOP prensiplerinden birinin aciklamasini gormek icin bas harfine tikladiktan sonra enter'a basin aciklamasini gorebilirsiniz\nAbstraction:a\nEncapsulation:e\nInheritance:i\nPolymorphism:p\n\n");

                principleCode = Console.ReadLine();

                Descriptions description = new Descriptions();

                description.GetDescription(principleCode);

                counter++;
            }

            Console.ReadKey();
        }
    }
}
