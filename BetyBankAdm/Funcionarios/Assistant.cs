using BetyBankAdm.Model;

namespace BetyBankAdm.Funcionarios
{
    public class Assistant : BaseModel
    {
        public Assistant(string name, string cpf) : base(name, cpf, 2000) 
        { 
        }
        public override decimal GetBonus()
        {
            return Wage * 0.2M;
        }
        public override void IncreaseSalary()
        {
            Wage *= 1.1M;
        }
    }
}