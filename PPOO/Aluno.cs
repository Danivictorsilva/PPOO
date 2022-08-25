using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Aluno : Pessoa
    {

        protected String Registro;
        protected DateTime DataMtla;

        public Aluno() { }

        public void setRegistro()
        {
            Console.Write("Digite o numero de Registro: ");
            this.Registro = Console.ReadLine();
        }
        public String getRegistro()
        {
            return Registro;
        }
        public void setDataMtla()
        {
            Console.Write("Digite a Data de Matricula: ");
            this.DataMtla = DateTime.Parse(Console.ReadLine());
        }
        public String getDataMtla()
        {
            return DataMtla.ToShortDateString();
        }
        public override string ToString()
        {
            return String.Format("{{'Nome': {0},\n" +
                "'Data de Nascimento': {1},\n" +
                "'CPF': {2},\n" +
                "'Registro': {3},\n" +
                "'Data de Registro': {4}}}",
                getNome(), getDataNcto(), getCPF(), getRegistro(), getDataNcto());
        }
        public void CadastrarAluno()
        {
            base.CadastrarPessoa();
            setRegistro();
            setDataMtla();
        }
    }
}
