using System;
namespace DelegateUnderstanding
{
    class PrintimgService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }
}