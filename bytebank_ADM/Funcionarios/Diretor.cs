﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Diretor:Funcionario
    {
        public double getBonificacao()
        {
            return this.Salario;
        }
    }
}
