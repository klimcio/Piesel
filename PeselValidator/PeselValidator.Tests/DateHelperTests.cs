using PeselValidator.Tools;

namespace PeselValidator.Tests;

internal class DateHelperTests
{
    [Test]
    public void Test_Date_From_2000s() 
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");

    [Test]
    public void Test_Date_From_1900s()
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");

    [Test]
    public void Test_Date_From_1800s()
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");

    [Test]
    public void Test_Date_From_2100s()
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");

    [Test]
    public void Test_Date_From_2200s()
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");

    [Test]
    public void Dates_From_2300s_Are_Invalid()
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");

    [Test]
    public void Dates_From_1700s_Are_Invalid()
        => DateHelpers.ConvertToPeselDate(2021, 10, 10).Should().Equal("213010");
}
