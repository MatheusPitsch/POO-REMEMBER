using BetyBankAdm.Model;
using BetyBankAdm.SystemInternal;

namespace BetyBankAdm.Funcionarios
{
    public class Director : BaseModelManegar, IAuthentic
    {                
        public Director(string password, string name, string cpf) : base(password,name, cpf, 5000)
        {        
        }       

        override public decimal GetBonus()
        {
            return this.Wage + 0.15M;
        }
        public override void IncreaseSalary()
        {
            this.Wage += this.Wage * 0.15M;
        }
    }
}