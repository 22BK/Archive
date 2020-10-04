using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Store
    {
        private int totalProduct = 0;

        public void GetProduct()
        {
            Console.WriteLine(totalProduct.ToString());
        }

        public void AddProduct(int piece)
        {
            totalProduct = totalProduct + piece;
        }

        public void TakeProduct(int piece)
        {
            totalProduct = totalProduct - piece;
        }
    }
}
