using Calculadora.services;

namespace CalculadoraTestes;

public class CalculadoraTests
{//eu preciso ser bem especifico na descrição do meu método de teste.
 //reparar, como eu tenho que fazer para passar um "valor" ou instanciação dentro de uma classe. Lembrar, sempre com o construtor.
 //se atentar, que eu tentei passar o valor direto, e não deu erro. E lembrar que no exemplo passado de Pessoa, teve hora que eu fiz a declaração, dentro da classe e passei o valor para ela. Utilizei somente o método GET, da minha propriedade.
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }



    [Fact]// essa assinatura indica que ele é um método de teste.
    public void DeveSomar5Com10ERetornar15()
    {

        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Given
        int num1 = 10;
        int num2 = 10;
        // When
        int resultado = _calc.Somar(num1, num2);
        // Then
        Assert.Equal(20, resultado);
    }
}