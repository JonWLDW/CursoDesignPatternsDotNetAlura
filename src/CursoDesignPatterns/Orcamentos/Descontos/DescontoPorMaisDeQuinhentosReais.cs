namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class DescontoPorMaisDeQuinhentosReais
	{
		public double Calcular(Orcamento orcamento)
		{
			if (orcamento.Valor > 500.0)
				return orcamento.Valor * 0.07;

			return 0.0;
		}
	}
}