using System;

namespace CursoDesignPatterns.Investimentos
{
    class InvestimentoArrojado : IInvestimento
	{
        private Random _random;

        public InvestimentoArrojado()
        {
            _random = new Random();
        }

        public double Calcular(Conta conta)
        {
            int chute = _random.Next(10);
            if (chute >= 0 && chute <= 1) return 
                    conta.Saldo * 0.5;

            else if (chute >= 2 && chute <= 4) 
                return conta.Saldo * 0.3;

            else 
                return conta.Saldo * 0.006;
        }
    }
}
