using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Endereco
    {
        public String Rua { get; set; }
        
        public int Numero { get; set; }

        public Endereco() { }
        public void CadastrarEndereco()
        {
            Console.Write("Insira sua Rua: ");
            this.Rua = Console.ReadLine();
            Console.Write("Insira o Numero da sua rua: ");
            this.Numero = int.Parse(Console.ReadLine());
        }

    }
}
