using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Product prod = new Product(); abstract class olduğu için instance alınamaz sadece alt sınıfları kullanılabilir

            Water water = new Water();
            water.Name = "Buzdağı";
            water.Size = "0.5lt";
            water.getProductInfo();

            Disinfectant disinfectant = new Disinfectant();
            disinfectant.Name = "Dezenfekt";
            disinfectant.AlcoholRate = "80percent";
            disinfectant.getProductInfo();

            Console.ReadKey();

        }
    }
}
