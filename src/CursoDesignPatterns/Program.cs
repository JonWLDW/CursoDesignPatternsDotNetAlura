using CursoDesignPatterns.Orcamentos;
using System;
using CursoDesignPatterns.Orcamentos.Impostos;

namespace CursoDesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			Imposto iss = new ISS();
			Imposto icms = new ICMS();
			Imposto iccc = new ICCC();
			Orcamento orcamento = new Orcamento(valor: 500.0);
			CalculadorDeImpostos calculador = new CalculadorDeImpostos();
			calculador.RealizarCalculo(orcamento, icms);
			calculador.RealizarCalculo(orcamento, iss);
			calculador.RealizarCalculo(orcamento, iccc);
			Console.ReadLine();
		}
	}
}