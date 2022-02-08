using Alura.LeilaoOnline.Core;
using System;

namespace Alura.LeilaoOnline.ConsoleApp
{
    internal class Program
    {
        private static void Verifica(double valorEsperado, double valorObtido)
        {
            var cor = Console.ForegroundColor;

            if (valorEsperado == valorObtido)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Teste OK");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Teste Falhou. " +
                    $"Esperado: {valorEsperado} " +
                    $"Obtido: {valorObtido}");
            }
            Console.ForegroundColor = cor;
        }
        static void Main(string[] args)
        {
        }
    }
}