using PeselValidator.Tools;

namespace PeselValidator.Tests;

[TestFixture]
public class InvalidPeselFormatTests
{
    [Test]
    public void Pesel_should_have_11_digits_not_more()
    {
        var pesel = PeselResult.CreatePeselObject("123456789111");

        pesel.Result.Should().Be(ResultType.NotAStringOf11Digits);
        pesel.Pesel.Should().BeNull();
    }

    [Test]
    public void Pesel_should_have_11_digits_not_less()
    {
        var pesel = PeselResult.CreatePeselObject("1234567891");

        pesel.Result.Should().Be(ResultType.NotAStringOf11Digits);
        pesel.Pesel.Should().BeNull();
    }

    [Test]
    public void Pesel_should_contain_only_digits()
    {
        var pesel = PeselResult.CreatePeselObject("12345a78912");

        pesel.Result.Should().Be(ResultType.NotAStringOf11Digits);
        pesel.Pesel.Should().BeNull();
    }
}
