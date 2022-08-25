using System;
namespace PPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                CPF = "390",
                Nome = "Daniel",
                Endereco = new Endereco
                {
                    Rua = "Rua Const do Oitante",
                    Numero = 73
                }
            };

            Console.WriteLine(pessoa);

        }
    }
}
