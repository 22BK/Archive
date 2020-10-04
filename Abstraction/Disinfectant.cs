using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Disinfectant : Product
    {
        public string AlcoholRate { get; set; }

        public override string Category
        {
            get { return "Cleanup"; }
            set { }
        }

        public override void getProductInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Category: " + Category); 
            Console.WriteLine("AlcoholRate: " + AlcoholRate);
        }
    }
}
