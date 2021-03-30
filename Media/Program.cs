using System;
using System.Globalization;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.CalculaNotaFinal();
            aluno.MostraNotaFinal();

        }
    }
}
