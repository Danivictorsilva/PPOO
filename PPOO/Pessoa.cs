using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public String CPF { get; set; }

        public Endereco Endereco { get; set; }

        public Pessoa() { }

        public override string ToString()
        {
             return String.Format("{{'Nome': {0},\n" +
                "'CPF': {1},\n" +
                "'Rua': {2},\n" +
                "'Numero': {3}}}", 
                Nome,CPF, Endereco.Rua, Endereco.Numero);
        }
        /*public void CadastrarPessoa()
        {
            setNome();
            setCPF();
        }*/
    }
}
