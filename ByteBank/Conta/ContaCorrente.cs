using ByteBank.Cliente;

namespace ByteBank.Conta
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public Titular titular;
        private decimal saldo;


        public void MostrarSaldo()
        {
            Console.WriteLine("O saldo de " + titular + " é " + saldo);
        }

        public void Deposito(decimal valorDeposito)
        {
            if (valorDeposito >= 1)
            {
                saldo += valorDeposito;
                Console.WriteLine("Valor depositado na conta.");
            }
            else Console.WriteLine("Impossivel depositra o valor solicitado.");
        }

        public void Saque(decimal valorSaque)
        {
            if (VerificaSaldo(valorSaque))
            {
                this.saldo -= valorSaque;
                Console.WriteLine("Saque Realizada");
            }
            else Console.WriteLine("Valor do saque maior que saldo");
        }

        public void Transferencia(decimal valorTransferencia)
        {
            if (VerificaSaldo(valorTransferencia))
            {
                this.saldo -= valorTransferencia;
                Console.WriteLine("Transferencia Realizada");
            }
            else Console.WriteLine("Não foi possivel realizar a transferencia");
        }

        public bool VerificaSaldo(decimal valor)
        {
            if (this.saldo >= valor) return true;

            return false;
        }

        public void SetSaldo(decimal saldo)
        {
            if (saldo > 0) this.saldo = saldo;            
        }

        public void GetSaldo()
        {
            Console.WriteLine(this.saldo);
        }
    }
}
