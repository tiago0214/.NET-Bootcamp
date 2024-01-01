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

    [Fact]
    public void VerificarSeEhUmNumeroPar()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);
    }

    // [Theory]  //por causa do theory, esse cenário de teste vai ser executado mais de uma vez.
    // [InlineData(2)]         //Isso é uma cadeia de dados que vai ser jogado cada um de uma vez, dentro do meu método de verificar.
    // [InlineData(4)]         //cada InlineData, é um teste diferente.
    // [InlineData(6)]         //Em um único teste, eu estou validando varios cenários.
    // [InlineData(8)]
    // [InlineData(10)]
    // public void DeveVerificarSeTodosOsNumerosPassadosSaoPares(int num)
    // {
    //     //Act
    //     bool resultado = _calc.EhPar(num);
    //     //Assert
    //     Assert.True(resultado);
    // }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeTodosOsNumerosPassadosSaoPares(int[] numero)
    {//para percorrer a lista , eu poderia fazer com o foreach normal.

        // foreach (int item in numero)
        // {
        //     Assert.True(_calc.EhPar(item));
        // }

        //posso fazer tudo em uma linha só
        Assert.All(numero, num => Assert.True(_calc.EhPar(num)));
        // (Assert.All)esse método, recebe uma coleção como parametro e depois uma ação.
        //o método que eu passei, ele percorre todos os elementos da minha coleção. E executa a ação.
    }
}