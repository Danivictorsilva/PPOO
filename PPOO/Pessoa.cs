using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Pessoa
    {
        String Nome;
        String CPF;
        String Telefone;
        DateTime Date;

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
        public void setTelefone()
        {
            Console.Write("Digite o Telefone: ");
            this.Telefone = Console.ReadLine();
        }
        public String getTelefone()
        {
            return this.Telefone;
        }
        public void setDate()
        {
            Console.Write("Digite a Data de Nascimento: ");
            this.Date = DateTime.Parse(Console.ReadLine());
        }
        public String getDate()
        {
            return this.Date.ToShortDateString();
        }

        public void ImprimirCadastro()
        {
             Console.WriteLine("{{'Nome': {0}, " +
                "'Data de Nascimento': {1}, " +
                "'CPF': {2}, " +
                "'Telefone': {3}}}", 
                this.Nome, this.Date.ToShortDateString(), this.CPF, this.Telefone);
        }

        public void CadastrarPessoa()
        {
            setNome();
            setDate();
            setCPF();
            setTelefone();
        }
    }
}
