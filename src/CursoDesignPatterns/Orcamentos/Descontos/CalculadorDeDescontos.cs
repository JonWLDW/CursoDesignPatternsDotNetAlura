namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class CalculadorDeDescontos
	{
		public double Calcular(Orcamento orcamento)
		{
			var descontoCincoItens = new DescontoPorCincoItens();
			var descontoMaisDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
			descontoCincoItens.ProximoDesconto = descontoMaisDeQuinhentosReais;
			descontoMaisDeQuinhentosReais.ProximoDesconto = new SemDesconto();

			return descontoCincoItens.Calcular(orcamento);
		}
	}
}