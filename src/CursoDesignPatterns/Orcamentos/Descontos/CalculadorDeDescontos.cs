namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class CalculadorDeDescontos
	{
		public double Calcular(Orcamento orcamento)
		{
			if (orcamento.Itens.Count > 5)
				return orcamento.Valor * 0.1;

			else if (orcamento.Valor > 500.0)
				return orcamento.Valor * 0.07;

			return 0.0;
		}
	}
}