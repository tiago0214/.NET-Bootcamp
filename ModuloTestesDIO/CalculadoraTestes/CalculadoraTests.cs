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



    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {

        //Arrange
        //Act
        //Assert
    }
}