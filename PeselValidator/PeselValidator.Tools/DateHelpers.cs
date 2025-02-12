using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PeselValidator.Tests")]

namespace PeselValidator.Tools;

internal class DateHelpers
{
    private readonly Dictionary<int, int> CenturyModifiers = new()
    {
        { 1800, 80 },
        { 1900, 0 },
        { 2000, 20 },
        { 2100, 40 },
        { 2200, 60 }
    };

    public static string[] ConvertToPeselDate(int year, int month, int day)
    {
        throw new NotImplementedException();
    }
}
