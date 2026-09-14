using StudentUtility;
namespace StudentUtility.Tests;
public class UnitTest1
{
    [Fact]
    public void AddNumbers_ReturnsCorrectResult()
    {
        var result = StudentHelper.AddNumbers(2, 3);
        Assert.Equal(10, result);
    }
}