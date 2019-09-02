using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Larissah_1703323
{
	public class Ornamental : Planta
	{
		public string Paisagem { get; set; }
		public string GerarHash()
		{
			return "";
		}
		public Ornamental()
		{

		}
		public Ornamental(string _paisagem)
		{
			Paisagem = _paisagem;
		}
		public List<object> GerarLista()
		{
			List<object> listaPlantas = new List<object>();
			listaPlantas.Add(new Ornamental("Lirio"));
			return listaPlantas;
		}

	}
}
