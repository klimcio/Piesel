namespace PeselValidator.Tools;

public class PeselNumber
{
    public PeselNumber(int[] numbers)
    {
        Numbers = numbers;
    }

    public int[] Numbers { get; }

    internal static PeselNumber Create(int[] numbers) 
        => new(numbers);
}
