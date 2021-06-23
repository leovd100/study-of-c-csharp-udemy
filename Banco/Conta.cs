using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {

        public int Numero { get; private set; }
        private string _nome;
        private double _valor;



        public Conta (int numero, string nome)
        {
            Numero = numero;
            setNome(nome);
            _valor = 0.0 ;
        }

        public Conta(int numero, string nome, double valor)
        {
            Numero = numero;
            setNome(nome);
            _valor = valor;
        }



        private void setNome(string nome)
        {
            if(nome != null || nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public void Deposito(double valor)
        {
            _valor += valor;
        }

        public void Saque(double valor)
        {
            _valor -= valor + 5.0;
        }



        private double GetSaldo()
        {
            return _valor;
        }

        private string GetNome()
        {
            return _nome;
        }



        public override string ToString()
        {
            return $"Conta {Numero}, Titular : {GetNome()}, Saldo: R$ {GetSaldo()}";
        }
    }
}
