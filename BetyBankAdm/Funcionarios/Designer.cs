using BetyBankAdm.Funcionarios;

namespace BetyBankAdm.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }
        public override decimal GetBonificacao()
        {
            return Wage * 0.17M;
        }
        public override void AumentaSalario()
        {
            Wage *= 1.11M;
        }
    }
}