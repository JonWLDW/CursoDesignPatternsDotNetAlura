using CursoDesignPatterns.Orcamentos;
using System;
using CursoDesignPatterns.Orcamentos.Impostos;

namespace CursoDesignPatterns
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Informe o número da rotina!");
			var rotina = Console.ReadLine();

			switch (rotina)
			{
				case "1":
					RotinaDeCalculoDeImpostosNoPadraoStrategy();
					break;
					
				default:
					Console.WriteLine("Rotina inválida!");
					Main();
					break;
			}
		}

		private static void RotinaDeCalculoDeImpostosNoPadraoStrategy()
		{
			Console.WriteLine("Iniciada rotina de cálculo de desconto no padrão Strategy.\n");

			Imposto iss = new ISS();
			Imposto icms = new ICMS();
			Imposto iccc = new ICCC();
			Orcamento orcamento = new Orcamento(valor: 500.0);
			CalculadorDeImpostos calculador = new CalculadorDeImpostos();
			calculador.RealizarCalculo(orcamento, icms);
			calculador.RealizarCalculo(orcamento, iss);
			calculador.RealizarCalculo(orcamento, iccc);

			Console.WriteLine("\nFim da rotina de cálculo de desconto no padrão Strategy.");
			Main();
		}
	}
}