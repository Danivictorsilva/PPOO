using System;
namespace PPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new();

            pessoa.CadastrarPessoa();
            pessoa.ImprimirCadastro();
        }
    }
}
