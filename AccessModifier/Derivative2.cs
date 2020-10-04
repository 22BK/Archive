using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Derivative2 : Base // class public tanımlanmazsa altında tanımlanan her şey default private olur. !!Fakat Base aldığı class public ise kendisi de public gibi davranır
    {
        public string publicProp2 { get; set; } //public olarak belirtilmez ise default olarak private tanımlanır
        string prop2 { get; set; }
        void method() { }
    }
}
