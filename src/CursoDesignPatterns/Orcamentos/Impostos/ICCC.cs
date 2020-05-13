namespace CursoDesignPatterns.Orcamentos.Impostos
{
	public class ICCC : Imposto
	{
		public double Calcular(Orcamento orcamento)
		{
			if (orcamento.Valor < 1000.0)
				return orcamento.Valor * 0.05;

			if (orcamento.Valor <= 3000.0)
				return orcamento.Valor * 0.07;

			return (orcamento.Valor * 0.08) + 30.0;
		}
	}
}
