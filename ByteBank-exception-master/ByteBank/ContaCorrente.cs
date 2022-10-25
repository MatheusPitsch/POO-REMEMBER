// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; }
        public static int TotalDeContasCriadas { get; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            //TotalDeContasCriadas++;
            //TaxaOperacao = 30 / TotalDeContasCriadas;

            if (agencia <= 0) throw new ArgumentException("Agencia deve ser maior que 0", nameof(agencia));

            if (numero <= 0) throw new ArgumentException("Numero deve ser maior que 0", nameof(numero));

        }


        public void Sacar(double valor)
        {
            if (valor < _saldo) { Console.WriteLine("Saque realizado"); _saldo -= valor; }

            else throw new excecaoException($"O saldo é insuficiente, saldo: {this.Saldo}, valor do saque: {valor}");
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
