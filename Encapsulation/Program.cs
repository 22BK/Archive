using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            store.AddProduct(10);  //setMethod

            store.TakeProduct(5);  //setMethod

            //Console.WriteLine(store.totalProduct.ToSting());  totalProduct --> private

            store.GetProduct();  //getMethod

            Console.ReadKey();
        }
    }
}
