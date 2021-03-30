using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            //ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();



            //if (consoleKeyInfo.KeyChar == 's')
            //if (resp.ToString().ToLower() == "s")
            if (resp == 'S' || resp == 's')
            {
                Console.WriteLine("Entre com o valor de depósito inicial: ");
                decimal depositoinicial = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numero, titular, depositoinicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine("Dados da conta: {0}", conta);

            Console.WriteLine("Entre um valor para depósito: ");
            decimal deposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito = deposito;
            Console.WriteLine("Dados da conta atualizados: {0}", conta);

            Console.WriteLine("Entre um valor para saque: ");
            decimal saque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque = saque;
            Console.WriteLine("Dados da conta atualizados: {0}", conta);


        }
    }
}
