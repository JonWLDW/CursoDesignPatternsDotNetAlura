using System;

namespace CursoDesignPatterns.Investimentos
{
	public class InvestimentoModerado : IInvestimento
	{
		private Random _random;
		public InvestimentoModerado()
		{
			_random = new Random();
		}

		public double Calcular(Conta conta)
		{
			if (_random.Next(2) == 0)
				return conta.Saldo * 0.025;
			else
				return conta.Saldo * 0.007;
		}
	}
}