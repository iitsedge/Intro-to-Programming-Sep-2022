
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void SingleStringReturnsSameNumber()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1");
        Assert.Equal(1, result);
    }

    [Fact]
    public void TwoNumbersReturnSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2");
        Assert.Equal(3, result);
    }

    [Fact]
    public void ManyNumbersReturnsSum()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2,3,4");
        Assert.Equal(10, result);
    }

    [Fact]
    public void SumUsingNewLineDelimeter()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1\n2\n3\n4");
        Assert.Equal(10, result);
    }

    [Fact]
    public void SumUsingBothDelimeter()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2\n3,4");
        Assert.Equal(10, result);
    }

}
