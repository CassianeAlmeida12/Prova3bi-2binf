using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3bimestreprova
{
    internal class Administrativo: Funcionario
    {
        private string Funcao { get; set; } 

        public Administrativo()
        {

        }
        public Administrativo(string funcao, string nome, string cpf, int matricula, DateTime dataNascimento, 
            string sexo): base(nome, cpf, matricula, dataNascimento, sexo)
        {
            Funcao = funcao;
        }   
    }
}
