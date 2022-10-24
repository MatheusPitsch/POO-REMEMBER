using BetyBankAdm.SistemaInterno;

namespace BetyBankAdm.Funcionarios
{
    public class Diretor : Atentica
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }
        override public decimal GetBonificacao()
        {
            return this.Wage + 0.15M;
        }
        public override void AumentaSalario()
        {
            this.Wage += this.Wage * 0.15M;
        }
    }
}