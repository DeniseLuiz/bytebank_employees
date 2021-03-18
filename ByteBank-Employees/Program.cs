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
            Funcionario carlos = new Funcionario(1);
            carlos.Nome = "Carlos";
            carlos.CPF = "345.345.345-45";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.GetBonificacao());
            Console.ReadLine();

        }
    }
}
