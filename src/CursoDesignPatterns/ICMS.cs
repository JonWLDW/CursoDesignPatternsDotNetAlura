namespace CursoDesignPatterns
{
	public class ICMS
	{
		public double CalcularICMS(Orcamento orcamento)
		{
			return orcamento.Valor * 0.1;
		}
	}
}