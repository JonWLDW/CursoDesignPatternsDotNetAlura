namespace CursoDesignPatterns
{
	public class ICMS : Impostos.Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor * 0.1;
		}
	}
}