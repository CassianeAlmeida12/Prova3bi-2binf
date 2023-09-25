using System;
using _3bimestreprova;
class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> lista = new List<Funcionario>();
        List<Medico> lista2 = new List<Medico>();
        List<Administrativo> lista3 = new List<Administrativo>();


        try
        {
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção: ");
                Console.WriteLine("1 - Funcionario;");
                Console.WriteLine("2 - Medico;");
                Console.WriteLine("3 - Administrativo");
                Console.WriteLine("4 - Sair do programa\n");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    while (true)
                    {



                        Console.Write("\nInfome o nome do funcionário: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o cpf: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Informe a matricula: ");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe a data de nascimento: ");
                        DateTime datanascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Informe o sexo: ");
                        string sexo = Console.ReadLine();

                        //Console.Write("Informe o salario: ");
                        //double salario = Convert.ToDouble(Console.ReadLine());


                        Funcionario a = new Funcionario(nome, cpf, matricula, datanascimento, sexo);

                        a.CalculoSalario();

                        lista.Add(a);

                        Console.Write("\nDigite 1 para sair: ");
                        int sair = Convert.ToInt32(Console.ReadLine());
                        if (sair == 1)
                        {
                            break;
                        }
                    }
                }

                else if (opcao == 2)
                {
                    while (true)
                    {
                        Console.Write("\nInfome o nome do médico: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o cpf: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Informe a matricula: ");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe a data de nascimento: ");
                        DateTime datanascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Informe o sexo: ");
                        string sexo = Console.ReadLine();
                        Console.Write("Informe o salario: ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe a CRM: ");
                        string crm = Console.ReadLine();

                        //Console.Write("Informe a hora extra: ");
                        //double horaextra = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Informe a especialidade: ");
                        string especialidade = Console.ReadLine();
                        Medico b = new Medico(crm, especialidade, nome, cpf, matricula, datanascimento, sexo);

                        b.CalculoSalario();

                        lista2.Add(b);

                        Console.Write("\nDigite 1 para sair: ");
                        int sair = Convert.ToInt32(Console.ReadLine());
                        if (sair == 1)
                        {
                            break;
                        }
                    }

                }

                else if (opcao == 3)
                {
                    while (true)
                    {
                        Console.Write("\nInforme a função: ");
                        string funcao = Console.ReadLine();
                        Console.Write("Infome o nome do funcionário: ");
                        string nome = Console.ReadLine();
                        Console.Write("Informe o cpf: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Informe a matricula: ");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Informe a data de nascimento: ");
                        DateTime datanascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Informe o sexo: ");
                        string sexo = Console.ReadLine();
                        Console.Write("Informe o salario: ");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Administrativo c = new Administrativo(funcao, nome, cpf, matricula, datanascimento, sexo);

                        lista3.Add(c);

                        Console.Write("\nDigite 1 para sair: ");
                        int sair = Convert.ToInt32(Console.ReadLine());
                        if (sair == 1)
                        {
                            break;
                        }

                    }
                }
                else if (opcao == 4)
                {
                    foreach (Funcionario funcionario in lista)
                    {
                        Console.WriteLine("Nome do Funcionario: " + + );
                    }
                    break;
                }
            }

        }
        catch(Exception e)
        {
            Console.WriteLine("erro");
        }

    }
}
