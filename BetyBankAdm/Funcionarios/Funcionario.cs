using System;
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
        public static int ContadorFuncionario { get; private set; }
        public virtual decimal GetBonificacao()
        {   
            return this.Wage * 0.10M;
        }
        public Funcionario()
        {
            ContadorFuncionario++;
        }
    }
}