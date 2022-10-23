﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetyBankAdm.Funcionarios
{
    public abstract class Funcionario
    {
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public decimal Wage { get; protected set; }
        public static int ContadorFuncionario { get; private set; }
        public abstract decimal GetBonificacao();                
        public Funcionario(string cpf, decimal wage)
        {
            this.Wage = wage;
            this.Cpf = cpf;
            ContadorFuncionario++;
        }
        public abstract void AumentaSalario();    
    }
}