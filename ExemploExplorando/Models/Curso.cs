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
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }


        //pelo o que eu vi, eu consigo mecher com coisas, por exemplo retornar uma informação. Mesmo se eu não passar ela como parametro.não tem nada a ver com escopo, quando eu não preciso passar parametro e mesmo assim eu consigo retornar algo. É porque eu não estou trabalhando com a coisa que eu estou retornando , eu simplismente estou fazendo o retorno de algo. Ou seja, eu não estou trabalhando com aquela situação. (manipulando ela)
    }
}