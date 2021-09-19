using System;

namespace Funcoes2
{
	class Program
	{
		static void Main(string[] args)
		{
			Produto produto = new Produto();
			produto.Nome = "Chocolate";
			produto.Preco = 15.0;
			produto.Taxa = 0.25;

			produto.PrecoFinal();

			Console.WriteLine($"O preço final do {produto.Nome} é {produto.PrecoFinal()}");	


			Console.ReadLine();
		}

		
	}
}
