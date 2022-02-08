using Xunit;

namespace BuildAPileOfCubes;

public class KataTests
{
    [Theory]
    [InlineData(45,1071225)]
    [InlineData(2022,4183059834009)]
    [InlineData(4824,135440716410000)]
    [InlineData(3568,40539911473216)]
    public void When_n_found_return_it(long expected, long m)
    {
        long actual = Kata.FindNB(m);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(24723578342962)]
    [InlineData(91716553919377)]
    public void When_n_not_found_return_less_one(long m)
    {
        long expected = -1;
        long actual = Kata.FindNB(m);
        Assert.Equal(expected,actual);
    }
}
