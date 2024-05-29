using Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculosTest;

public class CalculoUnitTest
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(-4, -6, -10)]
    [InlineData(-2, 2, 0)]
    [InlineData(int.MinValue, +1, int.MinValue +1)]
    public void SomarDoisNumerosRelativosRetornaNumeroRelativo(int num1, int num2, int valorEsperado)
    {
        //Act
        var resultado = Operacoes.Somar(num1, num2);

        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void SomarDoisDoubleRetornaDouble()
    {
        //Arrnage
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = 6;

        // Act
        var soma = Operacoes.Somar(num1,num2);

        //Assert
        Assert.Equal(valorEsperado, soma);
    }

    [Fact]
    public void Subtrair_DoisDouble_RetornaDouble()
    {
        // Arrange  
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = -0.2;

        // Act  
        var subtracao = Operacoes.Subtrair(num1, num2);

        //Assert  
        Assert.Equal(valorEsperado, subtracao,1);
    }

    [Fact]
    public void Multiplicar_DoisDouble_RetornaDouble()
    {
        // Arrange  
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = 8.99;

        // Act  
        var mult = Operacoes.Multiplicar(num1, num2);

        //Assert  
        Assert.Equal(valorEsperado, mult, 2);
    }

    [Fact]
    public void Dividir_DoisDouble_RetornaDouble()
    {
        // Arrange  
        var num1 = 2.9;
        var num2 = 3.1;
        var valorEsperado = 0.94; //Rounded value  

        // Act  
        var div = Operacoes.Dividir(num1, num2);

        //Assert  
        Assert.Equal(valorEsperado, div, 2);
    }
}
