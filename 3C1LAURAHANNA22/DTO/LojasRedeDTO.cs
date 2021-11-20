using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _3C1LAURAHANNA22.DTO
{
    class LojasRedeDTO
    {
		internal string Codigo;
		private int _codigo;
		private string _produto;
		private string _preco;
		private int value;

		public int Id { get => _codigo = value; }
		public string Produto { get; internal set; }
		public string Preco { get; internal set; }
	}
}
