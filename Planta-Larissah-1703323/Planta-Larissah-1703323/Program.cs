using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planta_Larissah_1703323;

namespace Planta_Larissah_1703323
{
	class Program
	{
		static void Main(string[] args)
		{
			Ornamental orn = new Ornamental();
			orn.Caracteristica = "branca";
			orn.Nome = "Lirio";
			orn.ID = 1;


			Console.WriteLine("Planta: " + orn.ObterNome());


			foreach (var item in orn.GerarLista())
			{
				Console.WriteLine();
			}

			Console.ReadKey();
		}
	}
}
