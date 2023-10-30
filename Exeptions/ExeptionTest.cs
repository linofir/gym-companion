namespace GymCompanion.Exeptions;

public class ExeptionTestException : System.Exception
{
    public ExeptionTestException() { }
    public ExeptionTestException(string message) : base(message) { }
    public ExeptionTestException(string message, System.Exception inner) : base(message, inner) { }
    protected ExeptionTestException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}