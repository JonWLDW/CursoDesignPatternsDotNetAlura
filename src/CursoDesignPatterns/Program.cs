using CursoDesignPatterns.Orcamentos;
using System;
using CursoDesignPatterns.Orcamentos.Descontos;
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

				case "2":
					RotinaDeCalculoDeDescontosNoPadraoChainOfResponsability();
					break;

				default:
					Console.WriteLine("Rotina inválida!");
					Main();
					break;
			}
		}

		private static void RotinaDeCalculoDeDescontosNoPadraoChainOfResponsability()
		{
			Console.WriteLine("Iniciada rotina de cálculo de desconto no padrão Chain of Responsability.\n");

			var orcamento = new Orcamento(valor: 500.00);
			orcamento.AdicionarItem(new Item("Caneta", valor: 250.00));
			orcamento.AdicionarItem(new Item("Lápis", valor: 250.00));

			var calculadorDeDescontos = new CalculadorDeDescontos();
			var valorDoDesconto = calculadorDeDescontos.Calcular(orcamento);
			Console.WriteLine($"Valor do Desconto: {valorDoDesconto:F2}");

			Console.WriteLine("\nFim da rotina de cálculo de desconto no padrão Chain of Responsability.");
			Main();
		}

		private static void RotinaDeCalculoDeImpostosNoPadraoStrategy()
		{
			Console.WriteLine("Iniciada rotina de cálculo de impostos no padrão Strategy.\n");

			Imposto iss = new ISS();
			Imposto icms = new ICMS();
			Imposto iccc = new ICCC();
			Orcamento orcamento = new Orcamento(valor: 500.0);
			CalculadorDeImpostos calculador = new CalculadorDeImpostos();
			calculador.RealizarCalculo(orcamento, icms);
			calculador.RealizarCalculo(orcamento, iss);
			calculador.RealizarCalculo(orcamento, iccc);

			Console.WriteLine("\nFim da rotina de cálculo de impostos no padrão Strategy.");
			Main();
		}
	}
}