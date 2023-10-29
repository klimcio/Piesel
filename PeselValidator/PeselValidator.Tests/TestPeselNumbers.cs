using Microsoft.Extensions.Configuration;

namespace PeselValidator.Tests;

public class TestPeselNumbers
{
    public string ValidPesel { get; set; } = default!;

    public static TestPeselNumbers Create(IConfigurationRoot Configuration)
    {
        return new TestPeselNumbers()
        {
            ValidPesel = Configuration["validPesel"] ?? RaiseConfigAlert("validPesel")
        };
    }

    protected static string RaiseConfigAlert(string field)
        => throw new ArgumentException($"{field} field was not set in configuration");
}
