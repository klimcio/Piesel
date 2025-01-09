using PeselValidator.Tools;

namespace PeselValidator.Tests;

[TestFixture]
public class DateConversionTests
{
    public record DateTestData(int Year, int Month, int Day, string Expected);

    [Datapoint] public DateTestData TestData1 = new(1874, 9, 3, "748903");
    [Datapoint] public DateTestData TestData2 = new(1987, 8, 13, "740813");
    [Datapoint] public DateTestData TestData3 = new(2061, 7, 23, "612723");
    [Datapoint] public DateTestData TestData4 = new(2199, 6, 30, "994630");
    [Datapoint] public DateTestData TestData5 = new(2232, 5, 2, "326502");

    [Theory]
    public void Test_Date_Conversion_For_Different_Centuries(DateTestData testData) 
        => DateConversionExtensions
        .ToPeselDate(testData.Year, testData.Month, testData.Day)
        .Should().Be(testData.Expected);

    [Test]
    public void Provided_Date_Must_Be_A_Date() 
        => DateConversionExtensions.ToPeselDate(2025, 2, 29).Should().BeNull();

    [Test]
    public void Provided_Date_Must_Be_A_Date2() 
        => DateConversionExtensions.ToPeselDate(2025, 13, 29).Should().BeNull();

    [Test]
    public void Provided_Date_Must_Be_A_Date3() 
        => DateConversionExtensions.ToPeselDate(2025, 11, 0).Should().BeNull();

    [Test]
    public void Provided_Date_Must_Be_A_Date4() 
        => DateConversionExtensions.ToPeselDate(2025, 11, 32).Should().BeNull();
}
