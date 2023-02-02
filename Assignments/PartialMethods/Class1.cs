using System;
using System.Collections.Generic;

namespace PartialMethods
{
    partial class MyPartialClass
    {
        partial void M();//partial method must not return void.

        static partial void N();//partial methids are implicitly private
        
        public static void CallStaticMethod()
        {
            N();
        }
        public void CallNonStaticMethod()
        {
            this.M();
        }

    }
}

