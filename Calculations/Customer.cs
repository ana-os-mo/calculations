namespace Calculations;

public class Customer
{
    public virtual int GetOrdersByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("My exception message");
        }

        return 100;
    }

    public int Age => 78;

    public string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}
