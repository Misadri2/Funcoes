using System;
using System.Collections.Generic;
using System.Text;

namespace Funcoes2
{
	public class Produto
	{
		public string Nome { get; set; }
		public double Preco { get; set; }
		public double Taxa { get; set; }

		public double PrecoFinal()
		{
			double calculo = Preco + (Preco * Taxa);
			return calculo;
		}
	}
}
