using System;
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {


            ContaNova conta;
            double valor = 0;


            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito incial (s/n) ?");
            char haDeposito = Char.Parse(Console.ReadLine());

            if(haDeposito == 's')
            {
                Console.Write("Entre com o valor de deposito: ");
                valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaNova(numeroConta, nome, valor);
            }
            else
            {
                conta = new ContaNova(numeroConta, nome);
            }


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);



            Console.WriteLine();
            Console.Write("Entre com um valor de deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

          

        }
    }
}
