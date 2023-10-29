using Microsoft.Extensions.Configuration;

namespace PeselValidator.Tests;

public class TheMotherOfAllTests
{
    protected TestPeselNumbers config;

    [OneTimeSetUp]
    public void RunBeforeAllTheTests()
    {
        var aConfig = new ConfigurationBuilder()
            .AddJsonFile("testsettings.json")
            .Build();

        config = TestPeselNumbers.Create(aConfig);
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}