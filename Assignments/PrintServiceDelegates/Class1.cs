using System;

namespace DelegateUnderstanding
{
    class PrintingService
    {
        public static void Print(Delegate d)
        {
            d();
        }
    }
}