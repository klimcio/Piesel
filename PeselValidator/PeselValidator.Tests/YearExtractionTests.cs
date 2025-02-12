using PeselValidator.Tools;

namespace PeselValidator.Tests;

[TestFixture]
public class YearExtractionTests
{
    public record DateTestData(string peselDate, int expectedYear);

    [Datapoint] public DateTestData TestData1 = new("748903", 1874);
    [Datapoint] public DateTestData TestData2 = new("740813", 1987);
    [Datapoint] public DateTestData TestData3 = new("612723", 2061);
    [Datapoint] public DateTestData TestData4 = new("994630", 2199);
    [Datapoint] public DateTestData TestData5 = new("326502", 2232);

    [Theory]
    public void Test_Year_Extraction_For_Different_Centuries(DateTestData testData)
        => DateConversionExtensions.ExtractYear(testData.peselDate).Should().Be(testData.expectedYear);
}