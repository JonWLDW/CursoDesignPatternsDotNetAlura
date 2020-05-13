using System.Linq;

namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class DescontoPorKitEspecifico : IDesconto
	{
		public IDesconto ProximoDesconto { get; set; }
		public double Calcular(Orcamento orcamento)
		{
			if (OrcamentoTemItemCestaBasica(orcamento))
				return orcamento.Valor * 0.15;

			return ProximoDesconto.Calcular(orcamento);
		}

		private bool OrcamentoTemItemCestaBasica(Orcamento orcamento)
		{
			return orcamento.Itens.Any(i => i.Nome.ToLower().Contains("cesta"));
		}
	}
}
