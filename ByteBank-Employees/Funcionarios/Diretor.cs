﻿using ByteBank_Employees.Funcionarios;
using ByteBank_Employees.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Employees.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor( string cpf) : base(5000, cpf)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}