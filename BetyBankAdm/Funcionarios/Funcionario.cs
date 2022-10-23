﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetyBankAdm.Funcionarios
{
    public class Funcionario
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public decimal Wage { get; set; }

        public decimal GetBonificacao()
        {   
            return this.Wage * 0.10M;
        }
    }
}