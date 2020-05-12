using System;

namespace CursoDesignPatterns.Investimentos
{
	public class RealizadorDeInvestimentos
	{
        public void Realiza(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcular(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}