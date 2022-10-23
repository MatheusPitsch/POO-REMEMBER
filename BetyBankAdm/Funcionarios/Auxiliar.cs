using BetyBankAdm.Funcionarios;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
        }

        public override decimal GetBonificacao()
        {
            return Wage * 0.2M;
        }

        public override void AumentaSalario()
        {
            Wage *= 1.1M;
        }
    }
}