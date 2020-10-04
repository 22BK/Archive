using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    public class Derivative1 : Base
    {

        public Derivative1()
        {
            Base baseClass = new Base();

            baseClass.publicProp = ""; // public her yerden erişilebilir
            baseClass.internalProp = ""; // internal aynı proje/dll içinde erişilebilir
            baseClass.protectedInternalProp = ""; //protected internal (or) ifadesi ile birleşmiştir farklı projede base classından türeyen classların içinde de bu property kullanılabilir

            protectedProp = ""; //protected tanımlanan classtan türeyen classlar içinde kulanılabilir
        }

        public void method() { }
    }
}
