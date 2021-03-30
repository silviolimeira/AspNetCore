using System;
using System.Globalization;

namespace Folha
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            f.SalarioBruto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            f.Imposto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados atualizados: " + f);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados atualizados: " + f);

        }
    }
}
