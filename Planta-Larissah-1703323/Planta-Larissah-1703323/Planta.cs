using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planta_Larissah_1703323
{
	public class Planta
	{
		private int id;
		public int ID { get { return id; } set { id = value; } }
		public string Nome { get; set; }
		public string Caracteristica { get; set; }
		public string Imagem { get; set; }
		public string Dicas { get; set; }

		public string ObterNome()
		{
			return Nome;
		}
	}
}
