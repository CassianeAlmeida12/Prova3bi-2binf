using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3bimestreprova
{
    internal class Funcionario
    {

        private string Nome { get; set; }
        private string Cpf { get; set; }
        private int Matricula { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Sexo { get; set; }
        //private double Salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string nome, string cpf, int matricula, DateTime dataNascimento, string sexo)//, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            //Salario = salario;
        }   

        public virtual double CalculoSalario()
        {
            Console.Write("Digite o salario que o funcionario recebe: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            return salario;

        }
    }
}
