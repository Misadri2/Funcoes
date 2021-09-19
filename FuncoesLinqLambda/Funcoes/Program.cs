using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaEmpregados
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> cidades = new List<string>();
			cidades.Add("São Paulo");
			cidades.Add("São José");
			cidades.Add("Taubaté");
			cidades.Add("Redenção");

			//Console.WriteLine(BuscarPrimeiroComLambda(cidades, "Taubaté"));

			BuscarListaComLambda(cidades, "São").ForEach(x => Console.WriteLine(x));
			Console.ReadLine();
		}

		//!FUNÇÃO QUE USA FOREACH PARA ACHAR PRIMEIRO ITEM QUE CORRESPONDAM AO TERMO
		public static string BuscarPrimeiroComForeach(List<string> lista, string termo)
		{
			foreach (string item in lista)
			{
				if (item.Equals(termo))
					return item;
			}
			return null;

		}


		//!FUNÇÃO QUE USA LINQ PARA ACHAR PRIMEIRO ITEM QUE CORRESPONDA AO TERMO
		public static string BuscarPrimeiroComLinq(List<string> lista, string termo)
		{
			return (from item in lista where item.Equals(termo) select item).FirstOrDefault();
		}


		//!FUNÇÃO QUE USA LAMBDA PARA ACHAR PRIMEIRO ITEM QUE CORRESPONDA AO TERMO
		public static string BuscarPrimeiroComLambda(List<string> lista, string termo)
		{
			return lista.FirstOrDefault(x => x.Equals(termo));
		}

		//!FUNÇÃO QUE USA LAMBDA PARA ACHAR LISTA DE ITENS QUE CORRESPONDA AO TERMO
		public static List<string> BuscarListaComLambda(List<string> lista, string termo)
		{
			return lista.Where(x => x.Contains(termo)).ToList();
		}
	}
}
