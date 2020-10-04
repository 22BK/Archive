using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    public class Base
    {
        public string publicProp { get; set; }
        protected string protectedProp { get; set; }
        private string privateProp { get; set; }
        internal string internalProp { get; set; }
        protected internal string protectedInternalProp { get; set; }
        //private protected string privateProtectedProp { get; set; } // C# sürüm 7,2 ve üzeri sürümlerde geçerlidir.
    }
}
