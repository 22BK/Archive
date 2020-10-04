using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Water : Product
    {
        public string Size { get; set; }

        public override string Category
        {
            get { return "Food"; }
            set { } 
        }

        public override void getProductInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Category: " + Category); 
            Console.WriteLine("Size: " + Size);
        }
    }
}
