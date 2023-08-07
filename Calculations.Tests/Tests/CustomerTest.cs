namespace Calculations.Tests.Tests;

using Factory;
using Fixtures;
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
    public void GetOrdersByName_GivenNameIsNull_ThrowsArgumentException()
    {
        var customer = _customerFixture.Customer;
        var exceptionMessage = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
        Assert.Equal("My exception message", exceptionMessage.Message);
    }

    [Fact]
    public void CheckAgeForDiscount_GivenAValidAge_ShouldAllowDiscount()
    {
        var customer = _customerFixture.Customer;
        Assert.InRange(customer.Age, 50, 80);
    }

    [Fact]
    public void CreateLoyalCustomer_GivenOrderGreater100_ReturnsLoyalCustomer()
    {
        var customer = CustomerFactory.CreateCustomerInstance(102);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }
}
