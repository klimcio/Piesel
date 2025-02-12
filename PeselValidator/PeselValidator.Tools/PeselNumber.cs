
namespace PeselValidator.Tools;

public class PeselNumber
{
    public PeselNumber(int[] numbers)
    {
        Numbers = numbers;
    }

    public int[] Numbers { get; }

    public Sex Sex => Numbers[9] % 2 == 0 ? Sex.Female : Sex.Male;

    public string Number => string.Join("", Numbers);

    internal static PeselNumber Create(int[] numbers) 
        => new(numbers);
}
