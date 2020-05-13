namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class DescontoPorCincoItens : IDesconto
	{
		public IDesconto ProximoDesconto { get; set; }

		public double Calcular(Orcamento orcamento)
		{
			if (orcamento.Itens.Count > 5)
				return orcamento.Valor * 0.1;

			return 0.0;
		}
	}
}