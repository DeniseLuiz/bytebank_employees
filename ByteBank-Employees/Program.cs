using ByteBank;
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
            CalcularBonificacao();
            Console.ReadLine();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.333.444-45");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("345.556.567-45");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("123.123.123-12");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("456.556.775-98");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
