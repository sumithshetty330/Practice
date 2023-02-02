using System;
using System.Collections;
using System.Linq;
namespace ExceptionBank
{
    public class Transaction : Exception
    {
        public Transaction() : base() { }
        public Transaction(string message) : base(message) { }  
        public Transaction(string message, Exception innerException) : base(message, innerException) { }    
    }
    
}