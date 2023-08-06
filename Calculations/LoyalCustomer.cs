namespace Calculations;

public class LoyalCustomer : Customer
{
    public LoyalCustomer()
    {
        Discount = 10;
    }

    public int Discount { get; set; }
}
