using Xunit;

namespace PlayingWithDigits;

public class DigPowTests
{

    [Fact]
    public void Test1()
    {
        Assert.Equal(1, DigPow.digPow(89, 1));
    }
    [Fact]
    public void Test2()
    {
        Assert.Equal(-1, DigPow.digPow(92, 1));
    }
    [Fact]
    public void Test3()
    {
        Assert.Equal(51, DigPow.digPow(46288, 3));
    }
}