using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    class Empregado
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public double Salario { get; private set; }


        public Empregado (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;   
        }


        public void aumento(double porcentagem)
        {
            Salario += (Salario * (porcentagem / 100));
        }
    }
}
