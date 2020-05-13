namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public class SemDesconto : IDesconto
	{
		public IDesconto ProximoDesconto { get; set; }
		public double Calcular(Orcamento orcamento)
		{
			return 0.0;
		}
	}
}