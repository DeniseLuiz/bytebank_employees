using ByteBank_Employees.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Employees.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }

}
