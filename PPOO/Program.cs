using System;
namespace PPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Aluno aluno = new Aluno();
            Funcionario funcionario = new Funcionario();

            //aluno.CadastrarAluno();
            //Console.WriteLine(aluno);

            //pessoa.CadastrarPessoa();
            //Console.WriteLine(pessoa);

            funcionario.CadastrarFuncionario();
            Console.WriteLine(funcionario);
        }
    }
}
