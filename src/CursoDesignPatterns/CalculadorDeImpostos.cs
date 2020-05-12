using System;

namespace CursoDesignPatterns
{
	public class CalculadorDeImpostos
	{
		public void RealizarCalculo(Orcamento orcamento, string imposto)
		{
			if (imposto.Equals("ICMS"))
			{
				double icms = orcamento.Valor * 0.1;
				Console.WriteLine(icms);
			} else if (imposto.Equals("ISS"))
			{
				double iss = orcamento.Valor * 0.06;
				Console.WriteLine(iss);
			}			
		}
	}
}