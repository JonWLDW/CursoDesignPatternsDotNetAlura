namespace CursoDesignPatterns
{
	public class ISS : Impostos.Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
	}
}
