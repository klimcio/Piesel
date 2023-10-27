namespace PeselValidator.Tools;

internal class PeselNumber
{
    private PeselNumber(string number)
    {
        Number = number;
    }

    public string Number { get; }

    public static PeselNumber Create(string number)
    {


        return new PeselNumber(number);
    }
}
