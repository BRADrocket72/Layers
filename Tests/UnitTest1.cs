using Xunit;
using FactorialService;

namespace Tests;

public class FacotorialTests
{
    FactorialServicer servicer = new FactorialServicer();

    [Fact]
    public void Test0()
    {
        var result = servicer.calcFactorial(0);
        Assert.Equal(1, result);

    }
    [Fact]
    public void Test1()
    {
        var result = servicer.calcFactorial(1);
        Assert.Equal(1, result);

    }

    [Fact]
    public void Test2()
    {
        var result = servicer.calcFactorial(2);
        Assert.Equal(2, result);

    }


    [Fact]
    public void Test5()
    {
        var result = servicer.calcFactorial(5);
        Assert.Equal(120, result);

    }
    [Fact]
    public void Test12()
    {
        var result = servicer.calcFactorial(12);
        Assert.Equal(479001600, result);

    }
}