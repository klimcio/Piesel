using PeselValidator.Tools;

namespace PeselValidator;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            var sex = GetSex();

            Console.Write("Please provide a PESEL: ");
            var enteredPesel = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(enteredPesel))
            {
                Console.WriteLine("You have to provide a PESEL number.");
                return;
            }
            var peselDate = enteredPesel[0..6];

            List<PeselNumber> validPesels = new();
            int invalidPesels = 0;

            for (int i = 0; i <= 99999; i++)
            {
                string formattedNumber = i.ToString("D5");
                string peselWannabe = $"{peselDate}{formattedNumber}";

                var peselObj = PeselResult.CreatePeselObject(peselWannabe);

                if (peselObj.Result == ResultType.OK)
                {
                    validPesels.Add(peselObj.Pesel!);
                    WriteLineGreen(peselWannabe);
                }
                else
                {
                    invalidPesels++;
                    WriteLineRed(peselWannabe);
                }
            }

            var howManyMales = validPesels.Where(x => x.Sex == Sex.Male).Count();
            var howManyFemales = validPesels.Where(x => x.Sex == Sex.Female).Count();

            WriteLineGreen($"{validPesels.Count().ToString()} valid pesels for {peselDate}");
            WriteLineGreen($"{howManyMales.ToString()} males and {howManyFemales.ToString()} females for {peselDate}");
            WriteLineRed($"{invalidPesels.ToString()} invalid pesels for {peselDate}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    static Sex? GetSex()
    {
        Console.Write("Choose sex (0 - female, 1 - male, anything else - both: ");
        var enteredSex = Console.ReadLine();

        switch (enteredSex)
        {
            case "0":
                return Sex.Female;
            case "1":
                return Sex.Male;
            default:
                return null;
        }
    }

    static void WriteLineGreen(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static void WriteLineRed(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}