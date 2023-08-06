namespace Calculations.Tests;

using Xunit;
using Xunit.Abstractions;

public class TestCollectionExecutionOrder : ITestCollectionOrderer
{
    public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
    {
        return testCollections.OrderBy(x => x.DisplayName);
    }
}
