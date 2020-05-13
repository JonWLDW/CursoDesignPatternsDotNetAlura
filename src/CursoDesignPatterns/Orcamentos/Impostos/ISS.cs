namespace CursoDesignPatterns.Orcamentos.Impostos
{
	public class ISS : Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}
	}
}
