using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Employees.Funcionarios
{
    public class Desenvolvedor: Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {

        }

        //DADOS OBRIGARÓRIOS, EM VIRTUDE DO ABSTRACT DA CLASSE FUNCIONÁRIO
        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            Salario += 1.10;
        }
    }
}
