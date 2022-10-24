using BetyBankAdm.Model;

namespace BetyBankAdm.Funcionarios
{
    public class Designer : BaseModel
    {
        public Designer(string name, string cpf) : base(name, cpf, 3000)
        {
        }
        public override decimal GetBonus()
        {
            return Wage * 0.17M;
        }
        public override void IncreaseSalary()
        {
            Wage *= 1.11M;
        }
    }
}