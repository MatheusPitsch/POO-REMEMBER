using ByteBank.Conta;
using ByteBank.Cliente;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            //ContaCorrente contaAndre = new ContaCorrente();

            //contaAndre.titular = "André";
            //contaAndre.numeroAgencia = 15;
            //contaAndre.conta = "1010-X";
            //contaAndre.saldo = 100;

            //ContaCorrente contaMaria = new ContaCorrente();

            //contaMaria.titular = "Maria";
            //contaMaria.numeroAgencia = 15;
            //contaMaria.conta = "1011-X";
            //contaMaria.saldo = 350;

            //contaAndre.Deposito(100);
            //contaAndre.MostrarSaldo();

            //Console.WriteLine("----/----");

            //contaAndre.Saque(50);
            //contaAndre.MostrarSaldo();

            //Console.WriteLine("----/----");

            //contaAndre.Transferencia(contaMaria, 50);
            //contaAndre.MostrarSaldo();
            //contaMaria.MostrarSaldo();
        }

        {
            Titular cliente = new Titular();
            cliente.titular = "André";
            cliente.profissao = "Programadro";
            cliente.cpf = "10590730920";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = cliente;
            conta.conta = "1010";
            conta.SetSaldo(100);
            conta.numeroAgencia = 15;
            
            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = cliente;
            conta2.conta = "1010";
            conta2.SetSaldo(100);
            conta2.numeroAgencia = 15;

            conta.Saque(200);
        }

        Console.ReadLine();
    }
}