using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Pessoa
    {
        //Propriedades
        public String Nome { get; set; }
        public String CPF { get; set; }
        public Endereco Endereco { get; set; }

        //Metodos
        public Pessoa() { }
        public override string ToString()
        {
            return String.Format("{{'Nome': {0}, " +
               "'CPF': {1}, " +
               "'Rua': {2}, " +
               "'Numero': {3}}}",
               Nome, CPF, Endereco.Rua, Endereco.Numero);
        }
        public void CadastrarPessoa()
        {
            Console.Write("Insira seu Nome: ");
            this.Nome = Console.ReadLine();
            Console.Write("Insira seu CPF: ");
            this.CPF = Console.ReadLine();
            this.Endereco = new Endereco();
            this.Endereco.CadastrarEndereco();
        }
    }
}
