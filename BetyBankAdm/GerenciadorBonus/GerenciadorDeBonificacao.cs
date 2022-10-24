using BetyBankAdm.Funcionarios;

namespace BetyBankAdm.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private decimal totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }                      

        public decimal GetBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}