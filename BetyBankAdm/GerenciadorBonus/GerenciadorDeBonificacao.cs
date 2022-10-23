using BetyBankAdm.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private decimal totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        public decimal GetBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}