namespace Calculations.Tests.Tests;

using Xunit;
using Xunit.Abstractions;

public class FibonacciTest : IClassFixture<FibonacciFixture>
{
    private readonly FibonacciFixture _fibonacciFixture;
    private readonly ITestOutputHelper _output;

    public FibonacciTest(ITestOutputHelper output, FibonacciFixture fibonacciFixture)
    {
        _output = output;
        _fibonacciFixture = fibonacciFixture;
        _output.WriteLine("FibonacciTest Constructor");
    }

    [Fact]
    [Trait("Category", "Fibonacci")]
    public void Fibonacci_DoesNotIncludeZero()
    {
        _output.WriteLine("Check if Fibonacci doesn't include 0");

        var fibonacci = _fibonacciFixture.Fibonacci;
        Assert.All(fibonacci.FibonacciNumbers, n => Assert.NotEqual(0, n));
        Assert.DoesNotContain(0, fibonacci.FibonacciNumbers);
    }

    [Fact]
    [Trait("Category", "Fibonacci")]
    public void Fibonacci_Includes13()
    {
        _output.WriteLine("Check if Fibonacci includes 13");

        var fibonacci = _fibonacciFixture.Fibonacci;
        Assert.Contains(13, fibonacci.FibonacciNumbers);
    }

    [Fact]
    [Trait("Category", "Fibonacci")]
    public void Fibonacci_DoesNotInclude4()
    {
        _output.WriteLine("Check if Fibonacci doesn't include 4. Test starting at {0}", DateTime.Now);

        var fibonacci = _fibonacciFixture.Fibonacci;
        Assert.DoesNotContain(4, fibonacci.FibonacciNumbers);
    }

    [Fact]
    [Trait("Category", "Fibonacci")]
    public void CheckCollection()
    {
        _output.WriteLine("Check Fibonacci Collection");

        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        var fibo = _fibonacciFixture.Fibonacci;
        Assert.Equal(expectedCollection, fibo.FibonacciNumbers);
    }
}
