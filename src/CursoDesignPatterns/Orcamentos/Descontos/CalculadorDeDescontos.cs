namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class CalculadorDeDescontos
	{
		public double Calcular(Orcamento orcamento)
		{
			var desconto = new DescontoPorCincoItens().Calcular(orcamento);
			if (desconto == 0.0)
				desconto = new DescontoPorMaisDeQuinhentosReais().Calcular(orcamento);

			return desconto;
		}
	}
}