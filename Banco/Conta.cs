using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Banco
{
    class Conta
    {
        private decimal _saldo;

        public int Numero { get; private set; }
        public string Titular { get; set; }

        public Conta() { }
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, decimal deposito) : this(numero, titular)
        {
            //_saldo = deposito;
            Deposito = deposito;
        }

        public decimal Deposito
        {
            set { 
                if (value > decimal.Parse("0.01", CultureInfo.InvariantCulture))
                {
                    _saldo += value;
                }
            }
        }

        public decimal Saque
        {
            set
            {
                if (value <= _saldo)
                {
                    _saldo -= (value + 5.00M);
                }
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
