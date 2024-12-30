namespace PeselValidator.Tools;

public class PeselException : Exception
{
    public PeselException(ResultType resultType)
    {
        ResultType = resultType;
    }

    public ResultType ResultType { get; }
}
