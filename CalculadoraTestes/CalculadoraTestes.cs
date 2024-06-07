using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplemantacao _calculadora;

    public CalculadoraTestes()
    {
        _calculadora = new CalculadoraImplemantacao();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange - Montar cenário
        int num1 = 5;
        int num2 = 10;

        // Act - Executar ação
        int resultado = _calculadora.Somar(num1, num2);

        // Asset - Validar resultado
        Assert.Equal(15, resultado); // primeiro o valor esperado
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calculadora.Somar(num1, num2);

        // Asset
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Given
        int numero = 4;

        // When
        bool resultado = _calculadora.EhPar(numero);
    
        // Then
        Assert.True(resultado);
    }

    // Utliazndo Theory
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        // Given

        // When
        bool resultado = _calculadora.EhPar(numero);
    
        // Then
        Assert.True(resultado);
    }

    // Utliazndo Theory com colação
    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiroLista(int[] numeros)
    {
        // Act / Assert

        // Exemplo com foreach
        // foreach (var numero in numeros) 
        // {
        //     Assert.True(_calculadora.EhPar(numero));
        // }

        // Mais otimizado
        Assert.All(
            numeros, 
             numero => 
                Assert.True(_calculadora.EhPar(numero))
        );
    }
}