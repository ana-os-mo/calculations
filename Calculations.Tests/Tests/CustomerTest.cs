namespace Calculations.Tests.Tests;

using Factory;
using Xunit;

[Collection("Customer")]
public class CustomerTest
{
    private readonly CustomerFixture _customerFixture;

    public CustomerTest(CustomerFixture customerFixture)
    {
        _customerFixture = customerFixture;
    }

    [Fact]
    public void GetOrdersByNameNotNull()
    {
        var customer = _customerFixture.Cust;
        var exceptionMessage = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
        Assert.Equal("Hello", exceptionMessage.Message);
    }

    [Fact]
    public void CheckLegiForDiscount()
    {
        var customer = _customerFixture.Cust;
        Assert.InRange(customer.Age, 50, 80);
    }

    [Fact]
    public void LoyalCustomerForOrdersGreater100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }
}
