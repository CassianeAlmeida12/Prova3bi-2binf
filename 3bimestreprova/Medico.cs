using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3bimestreprova
{
    internal class Medico : Funcionario
    {

        private string CRM { get; set; }
        //private double HoraExtra { get; set; }
        private string Especialidade { get; set; }

        public Medico()
        {

        }
        public Medico(string crm, string especialidade, string nome,
            string cpf, int matricula, DateTime dataNascimento, string sexo) : base(nome, cpf, matricula, dataNascimento, sexo)
        {
            CRM = crm;
            //HoraExtra = horaextra;
            Especialidade = especialidade;
        }

        public override double CalculoSalario()
        {
            double salario;
            double horaextra;
            Console.Write("\nInforme o salario do Medico: ");
            salario = Convert.ToDouble(Console.ReadLine());
            salario = (salario * 0.2) + salario;
            Console.Write("\nInforme a hora extra de tarbalho, se tiver: ");
            horaextra = Convert.ToDouble(Console.ReadLine());   

            if (horaextra > 0)
            {
                return salario += horaextra;
            }
            else
            {
                return salario;
            }
        }


    }       

}
