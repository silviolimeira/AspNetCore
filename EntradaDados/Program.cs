using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            decimal preco;
            string dados;
            string[] vet;
            string ultimoNome;
            int idade;
            float altura;
            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o último nome, idade, altura (mesma linha):");
            dados = Console.ReadLine();
            vet = dados.Split(' ');
            ultimoNome = vet[0];
            idade = int.Parse(vet[1]);
            altura = float.Parse(vet[2]);

            Console.WriteLine("=== Saída ===");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
