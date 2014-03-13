using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions.Interfaces
{
	public class Product
	{
		private string _privateField = "default";

		public int Id { get; set; }
		public string Name { get; set; }
	}
}
