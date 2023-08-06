namespace Calculations;

public class Customer
{
    public int Age => 78;

    public virtual int GetOrdersByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Hello");
        }

        // cantidad de ordenes (supuesto)
        return 100;
    }

    public string GetFullName(string firstName, string lastName)
    {
        return $"{firstName} {lastName}";
    }
}
