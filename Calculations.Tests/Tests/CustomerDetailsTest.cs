namespace Calculations.Tests.Tests;

using Xunit;

[Collection("Customer")]
public class CustomerDetailsTest
{
    private readonly CustomerFixture _customerFixture;

    public CustomerDetailsTest(CustomerFixture customerFixture)
    {
        _customerFixture = customerFixture;
    }

    [Fact]
    public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
    {
        var customer = _customerFixture.Cust;
        Assert.Equal("Ana Osorio", customer.GetFullName("Ana", "Osorio"));
    }
}
