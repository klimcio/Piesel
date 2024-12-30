using Microsoft.Extensions.Configuration;
using PeselValidator.Tools;

namespace PeselValidator.Tests;

public class ValidPeselValidationTests
{
    private TestPeselNumbers config;

    //[OneTimeSetUp]
    //public void RunBeforeAllTheTests()
    //{
    //    var aConfig = new ConfigurationBuilder()
    //        .AddJsonFile("testsettings.json")
    //        .Build();

    //    config = TestPeselNumbers.Create(aConfig);
    //}

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
    }
}