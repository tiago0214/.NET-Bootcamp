using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora//convenção : usar o I antes para indicar , mas eu posso colocar o nome que eu quiser.
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        //eu não tenho um corpo nos meus métodos, mas se eu quiser eu posso colocar.
        //outra coisa, eu não tenho public na frente, porque subentende que a minha interface é publica. Mas se eu colocar também, não tem problema.
        //só tem a assinatura do meu método. OU seja (tipo de retorno, Nome dele, Os parametros)


        //se eu colocar um corpo em um método. Eu torno ele opcional na minha implementação da minha interface.
        //agora os metodos que não tem corpo, eles são obrigatorios, a minha implementação
    }
}