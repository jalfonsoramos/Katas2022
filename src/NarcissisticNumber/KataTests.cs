using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace NarcissisticNumber;

public class KataTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(371)]
    public void When_number_is_narcissistic(int value)
    {
        bool result = Kata.Narcissistic(value);

        Assert.True(result);
    }

    [Theory]
    [InlineData(1938)]
    public void When_number_is_not_narcissistic(int value)
    {
        bool result = Kata.Narcissistic(value);

        Assert.False(result);
    }
}

public class Kata
{
    public static bool Narcissistic(int value)
    {
        var digits = value
                        .ToString()
                        .ToArray()
                        .Select(x => Int32.Parse(x.ToString()));

        var sum = digits.Sum(d => Math.Pow(d,digits.Count()));

        return sum == value;
    }
}