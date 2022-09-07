using System;
namespace PPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.CadastrarPessoa();
            Console.Clear();
            Console.WriteLine(pessoa);
        }
    }
}
