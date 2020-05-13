namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class CalculadorDeDescontos
	{
		public double Calcular(Orcamento orcamento)
		{
			var descontoCincoItens = new DescontoPorCincoItens();
			var descontoCestaBasica = new DescontoPorKitEspecifico();
			var descontoMaisDeQuinhentosReais = new DescontoPorMaisDeQuinhentosReais();
			var semDesconto = new SemDesconto();

			descontoCincoItens.ProximoDesconto = descontoCestaBasica;
			descontoCestaBasica.ProximoDesconto = descontoMaisDeQuinhentosReais;
			descontoMaisDeQuinhentosReais.ProximoDesconto = semDesconto;

			return descontoCincoItens.Calcular(orcamento);
		}
	}
}