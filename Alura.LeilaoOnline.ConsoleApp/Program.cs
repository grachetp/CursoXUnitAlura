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
        private static void LeilaoComApenasUmLance()
        {
            //Arrange - Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            leilao.RecebeLance(fulano, 800);

            //Act - Método sob teste
            leilao.TerminaPregao();

            //Assert - Resultado
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;

            Verifica(valorEsperado, valorObtido);
        }
        private static void LeilaoComVariosLances()
        {
            //Arrange - Cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            //Act - Método sob teste
            leilao.TerminaPregao();

            //Assert - Resultado
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            Verifica(valorEsperado, valorObtido);
        }

        static void Main(string[] args)
        {
            LeilaoComVariosLances();
            LeilaoComApenasUmLance();
        }
    }
}