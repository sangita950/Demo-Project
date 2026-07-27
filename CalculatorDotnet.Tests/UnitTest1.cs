using CalculatorDotnet;

namespace CalculatorDotnet.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSum()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsDifference()
    {
        Assert.Equal(6, Calculator.Subtract(10, 4));
    }

    [Fact]
    public void Multiply_ReturnsProduct()
    {
        Assert.Equal(21, Calculator.Multiply(3, 7));
    }

    [Fact]
    public void Divide_ReturnsQuotient()
    {
        Assert.Equal(4.0, Calculator.Divide(8, 2));
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(5, 0));
    }
}
