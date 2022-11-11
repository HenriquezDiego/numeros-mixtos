using Main;
namespace UnitTests;

public class ApplicationUnitTest
{
    [Fact]
    public void ConvertirNumeroMixtoToFraccion()
    {
        var mixedNumber = new NumeroMixto(3, new Fraccion(1, 2));
        var mixedNumber2 = new NumeroMixto(2, new Fraccion(3, 4));
        var f2 = mixedNumber2.ConvertToFraccion();
        var fraction = mixedNumber.ConvertToFraccion();
        Assert.Equal("7/2",fraction.ToString());
        Assert.Equal("11/4",f2.ToString());
    }

    [Fact]
    public void SimplificarFraccion()
    {
        Assert.Equal("5/4",new Fraccion(15,12).Simplify().ToString());
    }


    [Fact]
    public void SumaDeNumerosMixtos()
    {
        var n1 = new NumeroMixto(3, new Fraccion(1, 2));
        var n2 = new NumeroMixto(2, new Fraccion(3, 4));
        var result = n1 + n2;
        Assert.Equal("6 1/4", result.ToString());
    }

    [Fact]
    public void MixedFractionAdditionNegative()
    {
        var n1 = new NumeroMixto(-8, 2, 5);
        var result = n1.ConvertToFraccion();
        Assert.Equal("-42/5",result.ToString());
    }
}