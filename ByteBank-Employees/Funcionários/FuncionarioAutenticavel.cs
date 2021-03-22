using ByteBank_Employees.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Employees.Funcionários
{
    public abstract class FuncionarioAutenticavel : Funcionario , Autenticavel
    {
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }
        public string Senha { get; set; }

        public bool Autenticar (string senha)
        {
            return Senha == senha;
        }
    }
}
