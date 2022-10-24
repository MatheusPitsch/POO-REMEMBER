using BetyBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetyBankAdm.SistemaInterno
{
    public abstract class Atentica : Funcionario
    {
        public string password { get; set; }
        public void Authentic(string password)
        {           
        }
        public Atentica(string cpf, decimal wage) : base(cpf, wage)
        {
        }
        public override void AumentaSalario()
        {
            throw new NotImplementedException();
        }
        public override decimal GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
