namespace Calculations.Tests.Data;

public static class ShareableTestData
{
    public static IEnumerable<object[]> IsOddOrEvenData
    {
        get
        {
            yield return new object[] { 1, true };
            yield return new object[] { 200, false };
        }
    }

    public static IEnumerable<object[]> IsOddOrEvenExternalData
    {
        get
        {
            var allLines = File.ReadAllLines($"Data{Path.DirectorySeparatorChar}IsOddOrEvenTestData.txt");
            return allLines.Select(x =>
            {
                var lineSplit = x.Split(',');
                return new object[] { int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]) };
            });
        }
    }
}
