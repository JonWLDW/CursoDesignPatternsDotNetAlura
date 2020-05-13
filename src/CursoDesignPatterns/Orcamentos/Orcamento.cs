using System.Collections.Generic;

namespace CursoDesignPatterns.Orcamentos
{
	public class Orcamento
	{
		public double Valor { get; }
		public IList<Item> Itens { get; }

		public Orcamento(double valor)
		{
			Valor = valor;
			Itens = new List<Item>();
		}

		public void AdicionarItem(Item item)
		{
			Itens.Add(item);
		}
	}
}