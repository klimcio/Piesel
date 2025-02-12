using System.Text.RegularExpressions;

namespace PeselValidator.Tools;

public class PeselResult
{
    public PeselNumber? Pesel { get; private set; }
    public ResultType Result { get; private set; }

    private PeselResult(PeselNumber? pesel, ResultType result)
    {
        Pesel = pesel;
        Result = result;
    }

    public static PeselResult CreatePeselObject(string pesel)
    {
        try
        {
            if (!Contains11Digits(pesel))
                return new PeselResult(null, ResultType.NotAStringOf11Digits);

            var peselArray = pesel
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            // Validate Pesel Date


            if (ValidateCheckSum(peselArray.ToArray()))
                return new PeselResult(PeselNumber.Create(peselArray), ResultType.OK);
            else
                return new PeselResult(null, ResultType.InvalidChecksum);
        }
        catch (Exception)
        {
            return new PeselResult(null, ResultType.UnknownError);
        }
    }

    private static bool Contains11Digits(string pesel)
    {
        string elevenDigitsPattern = @"^\d{11}$";

        Regex regex = new Regex(elevenDigitsPattern);

        return regex.IsMatch(pesel);
    }

    private static bool ValidateCheckSum(int[] numbers)
    {
        var sum = numbers[0] * 1
            + numbers[1] * 3
            + numbers[2] * 7
            + numbers[3] * 9
            + numbers[4] * 1
            + numbers[5] * 3
            + numbers[6] * 7
            + numbers[7] * 9
            + numbers[8] * 1
            + numbers[9] * 3
            + numbers[10] * 1;

        return sum % 10 == 0;
    }
}
