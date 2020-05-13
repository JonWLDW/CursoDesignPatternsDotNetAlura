namespace CursoDesignPatterns.Orcamentos.Descontos
{
	public interface IDesconto
	{
		IDesconto ProximoDesconto { get; set; }
		double Calcular(Orcamento orcamento);
	}
}