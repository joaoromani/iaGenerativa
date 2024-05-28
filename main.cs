using System;
using System.IO;

namespace ImpostoDeRendaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do trabalhador: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salário bruto: ");
            decimal salarioBruto = decimal.Parse(Console.ReadLine());

            decimal impostoDeRenda = CalcularImpostoDeRenda(salarioBruto);
            decimal salarioLiquido = salarioBruto - impostoDeRenda;

            SalvarDados(nome, salarioLiquido);
            Console.WriteLine($"Salário líquido: {salarioLiquido:C}");
        }

        static decimal CalcularImpostoDeRenda(decimal salarioBruto)
        {
            return 0; // Implemente a lógica real de cálculo do imposto de renda
        }

        static void SalvarDados(string nome, decimal salarioLiquido)
        {
            // Implemente a lógica para salvar os dados em um arquivo de texto
        }
    }
}
