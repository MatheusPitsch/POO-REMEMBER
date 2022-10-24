using BetyBankAdm.Model;
using BetyBankAdm.SystemInternal;

namespace BetyBankAdm.Funcionarios
{
    public class ManagerAccount : BaseModelManegar, IAuthentic
    {        
        public ManagerAccount(string password, string name, string cpf) : base(password,name, cpf, 4000)
        {           
        }        

        public override decimal GetBonus()
        {
            return Wage * 0.25M;
        }      

        public override void IncreaseSalary()
        {
            Wage *= 1.05M;
        }
        
    }
}