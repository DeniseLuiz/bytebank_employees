using ByteBank_Employees.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "345.345.345-45");
            carlos.Nome = "Carlos";
            Console.WriteLine("salário: " + carlos.Salario);

            carlos.AumentarSalario();
            gerenciador.Registrar(carlos);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine("salário2: " + carlos.Salario);

            Diretor roberta = new Diretor("112.234.342-78");
            roberta.Nome = "Roberta";
            Console.WriteLine("salário roberta: " + roberta.Salario);
            roberta.AumentarSalario();
            Console.WriteLine("aumento roberta " + roberta.Salario);
            gerenciador.Registrar(roberta);

            Console.WriteLine(roberta.Nome);
            
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine("Total funcionário: " + Funcionario.TotalDeFuncionaios);
            Console.WriteLine("total: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();

        }
    }
}
