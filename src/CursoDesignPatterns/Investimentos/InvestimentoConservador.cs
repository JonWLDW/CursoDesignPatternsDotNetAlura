namespace CursoDesignPatterns.Investimentos
{
	public class InvestimentoConservador : IInvestimento
	{
		public double Calcular(Conta conta)
		{
			return conta.Saldo * 0.008;
		}
	}
}
