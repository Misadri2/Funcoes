using System;

namespace Funcoes
{
	class Program
	{

		public static void Tabuada( int num)
		{
			for (int i = 1; i <= 10; i++)
			{
				int resultado = num * i;
				Console.WriteLine(num + " X " + i + " = " + resultado);

			}
		}


		static void Main(string[] args)
		{
			//Tabuada

			Tabuada(9);
			Console.WriteLine("-------------------------------------");
			Tabuada(7);
			Console.WriteLine("-------------------------------------");
			Tabuada(2);
			

		}
	}
}
