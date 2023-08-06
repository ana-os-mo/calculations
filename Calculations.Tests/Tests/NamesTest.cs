﻿namespace Calculations.Tests.Tests;

using Xunit;

public class NamesTest
{
    [Fact]
    public void MakeFullNameTest()
    {
        var names = new Names();
        var result = names.MakeFullName("Ana", "Osorio");
        Assert.Equal("Ana Osorio", result, true);
        Assert.Contains("ana", result, StringComparison.InvariantCultureIgnoreCase);
        Assert.StartsWith("Ana", result);
        Assert.EndsWith("orio", result, StringComparison.InvariantCultureIgnoreCase);
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
    }

    [Fact]
    public void NickName_MustBeNull()
    {
        var names = new Names();
        Assert.Null(names.NickName);
        names.NickName = "Nickname";
        Assert.NotNull(names.NickName);
    }

    [Fact]
    public void MakeFullName_AlwaysReturnValue()
    {
        var names = new Names();
        var result = names.MakeFullName("Ana", "Osorio");
        Assert.False(string.IsNullOrEmpty(result));
    }
}