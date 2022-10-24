using BetyBankAdm.Funcionarios;

namespace BetyBankAdm.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {
        }
        public override decimal GetBonificacao()
        {
            return Wage * 0.25M;
        }      

        public override void AumentaSalario()
        {
            Wage *= 1.05M;
        }
    }
}