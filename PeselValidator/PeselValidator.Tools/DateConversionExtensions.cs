using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PeselValidator.Tests")]

namespace PeselValidator.Tools;

internal static class DateConversionExtensions
{
    public static string? ToPeselDate(int year, int month, int day)
    {
        throw new NotImplementedException();
    }

    public static int? ExtractYear(string peselDate)
    {
        throw new NotImplementedException();
    }
}