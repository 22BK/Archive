using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Product
    {
        public string Name { get; set; }
        public abstract string Category { get; set; }

        public virtual void getProductInfo()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Category: " + Category);
        }
    }
}
