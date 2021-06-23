using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Banco
{
    class ContaNova
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaNova(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaNova(int numero, string titular, double saldo) : this(numero, titular)
        {
            Deposito(saldo);
        }


        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }




        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo : R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }



    }
}
