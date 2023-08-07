namespace Calculations.Tests.Fixtures;

public class CalculatorFixture : IDisposable
{
    public Calculator Calculator => new();

    public void Dispose()
    {
        // Clean
    }
}
