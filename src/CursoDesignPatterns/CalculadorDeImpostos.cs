using CursoDesignPatterns.Impostos;
using System;

namespace CursoDesignPatterns
{
	public class CalculadorDeImpostos
	{
		public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
		{
			double icms = imposto.Calcular(orcamento);
			Console.WriteLine(icms);
		}
	}
}