using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.services;
using Xunit;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _string;

        public ValidacoesStringTests()
        {
            _string = new ValidacoesString();
        }



        [Fact]
        public void ValidarStringTextoCom5CaracteresEDeveRetornar5()
        {
            string texto = "tiago";

            int resultado = _string.ContarCaracteres(texto);

            Assert.Equal(5, resultado);

        }
    }
}