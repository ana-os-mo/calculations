namespace Calculations.Tests.Tests;

using Xunit;
using Xunit.Abstractions;

public class CalculatorTest : IClassFixture<CalculatorFixture>
{
    private readonly CalculatorFixture _calculatorFixture;
    private readonly ITestOutputHelper _output;

    public CalculatorTest(ITestOutputHelper output, CalculatorFixture calculatorFixture)
    {
        _output = output;
        _calculatorFixture = calculatorFixture;
        _output.WriteLine("CalculatorTest Constructor");
    }

    [Fact]
    [Trait("Category", "Calc")]
    public void Add_GivenTwoIntValues_ReturnsInt()
    {
        // Assert
        var calc = _calculatorFixture.Calc;
        var result = calc.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    [Trait("Category", "Calc")]
    public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
    {
        var calc = _calculatorFixture.Calc;
        var result = calc.AddDouble(1.23, 3.57);
        Assert.Equal(4.7, result, 0);
    }
}
