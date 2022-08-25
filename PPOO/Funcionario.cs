using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOO
{
    internal class Funcionario : Pessoa
    {
        protected String NPIS;
        protected String Setor;
        protected float Salario;

        public Funcionario() { }

        public void setNPIS()
        {
            Console.Write("Digite o Numero do PIS: ");
            this.NPIS = Console.ReadLine();
        }
        public String getNPIS()
        {
            return NPIS;
        }
        public void setSetor()
        {
            Console.Write("Digite o Setor: ");
            this.Setor = Console.ReadLine();
        }
        public String getSetor()
        {
            return Setor;
        }
        public void setSalario()
        {
            Console.Write("Digite o montante de Salario: ");
            this.Salario = float.Parse(Console.ReadLine());
        }
        public float getSalario()
        {
            return Salario;
        }
        public override string ToString()
        {
            return String.Format("{{'Nome': {0},\n" +
                "'Data de Nascimento': {1},\n" +
                "'CPF': {2},\n" +
                "'NPIS': {3},\n" +
                "'Setor': {4},\n" +
                "'Salario': {5}}}",
                getNome(), getDataNcto(), getCPF(), getNPIS(),getSetor(),getSalario());
        }
        public void CadastrarFuncionario()
        {
            base.CadastrarPessoa();
            setNPIS();
            setSetor();
            setSalario();
        }
    }
}
