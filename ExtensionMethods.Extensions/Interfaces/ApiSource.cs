using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions.Interfaces
{
	public class ApiSource : ApiSourceBase, IProductDataSource
	{
		public IEnumerable<Product> GetProducts()
		{
			return new List<Product>() { new Product() { Id = 5, Name = "Fifth" }, new Product() { Id = 6, Name = "Sixth" } };
		}
	}
}
