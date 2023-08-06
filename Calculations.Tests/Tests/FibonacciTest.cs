namespace Calculations.Tests.Tests;

using Xunit;
using Xunit.Abstractions;

public class FibonacciTest : IClassFixture<FiboFixture>
{
    private readonly FiboFixture _fiboFixture;
    private readonly ITestOutputHelper _output;

    public FibonacciTest(ITestOutputHelper output, FiboFixture fiboFixture)
    {
        _output = output;
        _fiboFixture = fiboFixture;
        _output.WriteLine("FibonacciTest Constructor");
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void Fibo_DoesNotIncludeZero()
    {
        _output.WriteLine("Check if Fibo doesn't include 0");

        var fibo = _fiboFixture.Fibo;
        Assert.All(fibo.FiboNumbers, n => Assert.NotEqual(0, n));
        Assert.DoesNotContain(0, fibo.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void Fibo_Includes13()
    {
        _output.WriteLine("Check if Fibo includes 13");

        var fibo = _fiboFixture.Fibo;
        Assert.Contains(13, fibo.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void Fibo_DoesNotInclude4()
    {
        _output.WriteLine("Check if Fibo doesn't include 4. Test starting at {0}", DateTime.Now);

        var fibo = _fiboFixture.Fibo;
        Assert.DoesNotContain(4, fibo.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void CheckCollection()
    {
        _output.WriteLine("Check Fibo Collection");

        var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
        var fibo = _fiboFixture.Fibo;
        Assert.Equal(expectedCollection, fibo.FiboNumbers);
    }
}
