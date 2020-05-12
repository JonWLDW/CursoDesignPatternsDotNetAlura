using System;

namespace CursoDesignPatterns
{
	public class CalculadorDeImpostos
	{
		public void RealizarCalculoICMS(Orcamento orcamento)
		{
			double icms = new ICMS().CalcularICMS(orcamento);
			Console.WriteLine(icms);
		}

		public void RealizarCalculoISS(Orcamento orcamento)
		{
			double iss = new ISS().CalcularISS(orcamento);
			Console.WriteLine(iss);
		}
	}
}