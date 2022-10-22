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
            cliente.Nome = "André";
            cliente.Profissao = "Programadro";
            cliente.Cpf = "10590730920";

            ContaCorrente conta = new ContaCorrente();
            conta.Titular = cliente;
            conta.conta = "1010";
            conta.SetSaldo(100);
            conta.NumeroAgencia = 15;
            
            ContaCorrente conta2 = new ContaCorrente();
            conta2.Titular = cliente;
            conta2.conta = "1010";
            conta2.SetSaldo(100);
            conta2.NumeroAgencia = 15;

            Console.WriteLine(conta.MostraConta()); 
        }

        Console.ReadLine();
    }
}