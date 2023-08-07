namespace Calculations.Tests.Tests;

using Data;
using Fixtures;
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
        _output.WriteLine("FibonacciTest Constructor is being executed");
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
    public void CheckCollectionContent()
    {
        _output.WriteLine("Check Fibonacci Collection");

        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        var fibonacci = _fibonacciFixture.Fibonacci;
        Assert.Equal(expectedCollection, fibonacci.FibonacciNumbers);
    }

    [Fact]
    public void IsOdd_GivenOddValue_ReturnsTrue()
    {
        var fibonacci = _fibonacciFixture.Fibonacci;
        var result = fibonacci.IsOdd(1);
        Assert.True(result);
    }

    [Fact]
    public void IsOdd_GivenEvenValue_ReturnsFalse()
    {
        var fibonacci = _fibonacciFixture.Fibonacci;
        var result = fibonacci.IsOdd(2);
        Assert.False(result);
    }

    [Theory]
    [InlineData(17, true)]
    [InlineData(200, false)]
    public void IsOdd_TestOddAndEven(int value, bool expected)
    {
        var fibonacci = _fibonacciFixture.Fibonacci;
        var result = fibonacci.IsOdd(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(ShareableTestData.IsOddOrEvenData), MemberType = typeof(ShareableTestData))]
    public void IsOdd_TestOddAndEven_WithSharedData(int value, bool expected)
    {
        var fibonacci = _fibonacciFixture.Fibonacci;
        var result = fibonacci.IsOdd(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(ShareableTestData.IsOddOrEvenExternalData), MemberType = typeof(ShareableTestData))]
    public void IsOdd_TestOddAndEven_WithExternalData(int value, bool expected)
    {
        var fibonacci = _fibonacciFixture.Fibonacci;
        var result = fibonacci.IsOdd(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [IsOddOrEvenData]
    public void IsOdd_TestOddAndEven_WithCustomAttribute(int value, bool expected)
    {
        var fibonacci = _fibonacciFixture.Fibonacci;
        var result = fibonacci.IsOdd(value);
        Assert.Equal(expected, result);
    }
}
