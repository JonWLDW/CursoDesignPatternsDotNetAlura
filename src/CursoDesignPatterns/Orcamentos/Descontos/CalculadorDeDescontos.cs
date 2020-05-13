namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class CalculadorDeDescontos
	{
		public double Calcular(Orcamento orcamento)
		{
			var descontoCincoItens = new DescontoPorCincoItens();
			var descontoMaisQueQuinheiDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
			descontoCincoItens.ProximoDesconto = descontoMaisQueQuinheiDeQuinhentosReais;

			return descontoCincoItens.Calcular(orcamento);
		}
	}
}