

namespace Greeter.UnitTests;
public class GreetingTests
{
    [Theory]
    [InlineData("Windom", "Hello, Windom!")]
    [InlineData("Cooper", "Hello, Cooper!")]
    public void SingleName(string name, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name) ;

        Assert.Equal(expected, greeting);
    }
    [Theory]
    [InlineData(null, "Hello, Cheif!")]
    public void NullName(string name, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
    [Theory]
    [InlineData("BOB", "HELLO, BOB!")]
    [InlineData("JACK", "HELLO, JACK!")]
    public void ShoutName(string name, string expected)
    {
        var greeter = new GreetingMaker();


        string greeting = greeter.Greet(name);

        Assert.Equal(expected, greeting);
    }
}
