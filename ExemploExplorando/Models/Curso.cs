using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }





        public void AdicionarAlunos(Pessoa aluno) //lembrar que esse argumento, pode ser o nome que eu quiser, igual os parametros das function em JS.
        {
            Alunos.Add(aluno);
        }
        public int QuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void MostrarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "N°" + count + " " + Alunos[count].NomeCompleto;//sempre lembrar que se eu deixar somente o Alunos[count], é como se fosse um objeto JS,ele não entra nas propriedades do objeto(falando de JS). Lembrar de quando eu estava criando um algoritmo de ordenação.
                Console.WriteLine(texto);
            }
        }
        //sempre lembrar, que tudo vai ser feito de acordo com a lista, se eu não usar o metodo adicionar para colocar os alunos, a minha lista vai ficar vazia , mesmo que eu tenho varias instancias da minha classe pessoa. As minhas instancias da minha classe pessoas não são automaticamente adcionada ao curso, se eu não fizer isso. Porque toda a mágica aqui, funciona com base na lista que eu criei. Nada haver com efetivamente com a classe pessoa e suas instanciação.
        //na real, eu preciso da classe pessoa, porque todos os meus metodos aqui, so aceitam passar parametros que são instanciações da minha classe do tipo pessoa.


        //pelo o que eu vi, eu consigo mecher com coisas, por exemplo retornar uma informação. Mesmo se eu não passar ela como parametro.não tem nada a ver com escopo, quando eu não preciso passar parametro e mesmo assim eu consigo retornar algo. É porque eu não estou trabalhando com a coisa que eu estou retornando , eu simplismente estou fazendo o retorno de algo. Ou seja, eu não estou trabalhando com aquela situação. (manipulando ela)
    }
}