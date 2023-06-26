
namespace StringCalculator;
public class StringCalculatorTests
{
    private readonly StringCalculator _calculator; 
     public StringCalculatorTests()
    {
        this._calculator = new StringCalculator()
    }
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();



        var result = calculator.Add("");



        Assert.Equal(0, result);
    }



    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("3", 3)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();



        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("11,10", 21)]
    [InlineData("2,1", 3)]
    [InlineData("80,10", 90)]
    public void TwoDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
        
    }
    [Theory]
    [InlineData("1", 1)]
    [InlineData("2,2", 4)]
    [InlineData("80,3,3,3", 89)]
    [InlineData("1,1,1,1", 4)]
    [InlineData("0,1,3,4,5", 13)]
    public void UnknownNumberOfDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }

    [Theory]
    [InlineData("1\n2,3", 6)]
    [InlineData("1\n2,7", 10)]
    public void NewLine(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);

    }


}