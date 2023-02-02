namespace ExceptionClassLibrary
{
    public class MarksOverException : Exception
{
    public MarksOverException(string message) : base(message) { }



    public MarksOverException(string message, Exception innerException) : base(message, innerException) { }
    public MarksOverException() : base() { }
}
public class MarksNegativeException : Exception
{
    public MarksNegativeException(string message) : base(message) { }



    public MarksNegativeException(string message, Exception innerException) : base(message, innerException) { }
    public MarksNegativeException() : base() { }
}
}
