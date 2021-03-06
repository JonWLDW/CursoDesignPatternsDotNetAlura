﻿namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class DescontoPorMaisDeQuinhentosReais : IDesconto
	{
		public IDesconto ProximoDesconto { get; set; }

		public double Calcular(Orcamento orcamento)
		{
			if (orcamento.Valor > 500.0)
				return orcamento.Valor * 0.07;

			return ProximoDesconto.Calcular(orcamento);
		}
	}
}