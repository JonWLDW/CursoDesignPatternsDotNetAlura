using System;
using CursoDesignPatterns.Orcamentos.Impostos;

namespace CursoDesignPatterns.Orcamentos
{
	public class CalculadorDeImpostos
	{
		public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
		{
			double valorDoImposto = imposto.Calcular(orcamento);
			Console.WriteLine(valorDoImposto);
		}
	}
}