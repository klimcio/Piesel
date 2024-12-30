using Microsoft.Extensions.Configuration;
using PeselValidator.Tools;

namespace PeselValidator.Tests;

[TestFixture]
public class ValidPeselValidationTests
{
    private TestPeselNumbers config;

    [SetUp]
    public void Setup()
    {
        var aConfig = new ConfigurationBuilder()
            .AddJsonFile("testsettings.json")
            .Build();

        config = TestPeselNumbers.Create(aConfig);
    }

    [Test]
    public void Provided_Pesel_Number_Is_Valid()
    {
        var pesel = PeselResult.CreatePeselObject(config.ValidPesel);

        pesel.Result.Should().Be(ResultType.OK);
        pesel.Pesel.Should().NotBeNull();
    }
}