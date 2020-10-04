using System;

namespace AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varsayılan olarak değişkenler ve methodlar private, classlar ise internaldır.

            Derivative1 derivative1 = new Derivative1();

            //erişilebilenler
            derivative1.publicProp = "";
            derivative1.internalProp = "";
            derivative1.protectedInternalProp = "";
            derivative1.method();

            Derivative2 derivative2 = new Derivative2();
            derivative2.publicProp2 = "";
            //derivative2.Prop2 = "";  default private
            //derivative2.method();  default private
        }
    }
}
