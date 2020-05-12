namespace CursoDesignPatterns
{
	public class ISS
	{
		public double CalcularISS(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
	}
}
