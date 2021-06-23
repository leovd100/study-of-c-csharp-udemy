using System;
using System.Globalization;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            string nome;
            double salario = 0.0;
            double porcentagem = 0.0;


            Console.Write("Digite a quantidade de empregados que quer inserir : ");
            int n = int.Parse(Console.ReadLine());
           
            List<Empregado> empregadoLista = new List<Empregado>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Empregado #" + (i+1) );
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());


                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Salário: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                empregadoLista.Add(new Empregado(id, nome, salario));

            }

            Console.Write("Entre com o ID do funcionário que você quer aumentar o salário : ");
            id = int.Parse(Console.ReadLine());

            int flag = 0;

            foreach(Empregado obj in empregadoLista)
            {
                if(obj.Id == id)
                {
                    Console.Write("Entre com a porcentagem: ");
                    porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    obj.aumento(porcentagem);
                    flag++;
                }
            }

            Console.WriteLine(flag == 1 ? "" : "Usuário não cadastrado");

            Console.WriteLine("-----------------------------------------------------------");


            foreach(Empregado obj in empregadoLista)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("ID: " + obj.Id + "Nome: " + obj.Nome + "Salário: " + obj.Salario.ToString("F2", CultureInfo.InvariantCulture));

            }


        }
    }
}
