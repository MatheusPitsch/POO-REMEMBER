using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetyBankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
        }

        override public decimal GetBonificacao()
        {
            return this.Wage + base.GetBonificacao();
        }
    }
}