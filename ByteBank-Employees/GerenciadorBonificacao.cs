using ByteBank_Employees.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Employees
{
    public class GerenciadorBonificacao
    {
        public void Registrar(Funcionario funcionario)
        {
            funcionario.GetBonificacao();
        } 
    }
}
