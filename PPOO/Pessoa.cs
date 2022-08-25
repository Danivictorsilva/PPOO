using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Pessoa
    {
        protected String Nome;
        protected String CPF;
        protected DateTime DataNcto;   

        public Pessoa() { }
        public void setNome ()
        {
            Console.Write("Digite o nome: ");
            this.Nome = Console.ReadLine();
        }
        public String getNome ()
        {
            return this.Nome;
        }
        public void setCPF()
        {
            Console.Write("Digite o CPF: ");
            this.CPF = Console.ReadLine();
        }
        public String getCPF()
        {
            return this.CPF;
        }
        public void setDataNcto()
        {
            Console.Write("Digite a Data de Nascimento: ");
            this.DataNcto = DateTime.Parse(Console.ReadLine());
        }
        public String getDataNcto()
        {
            return this.DataNcto.ToShortDateString();
        }
        public override string ToString()
        {
             return String.Format("{{'Nome': {0},\n" +
                "'Data de Nascimento': {1},\n" +
                "'CPF': {2}}}", 
                getNome(),getDataNcto(),getCPF());
        }
        public void CadastrarPessoa()
        {
            setNome();
            setDataNcto();
            setCPF();
        }
    }
}
