namespace CursoDesignPatterns.Orcamentos.Impostos
{
	public class ICMS : Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			return orcamento.Valor * 0.1;
		}
	}
}