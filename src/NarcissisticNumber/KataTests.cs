using System.Collections.Generic;
using Xunit;

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
