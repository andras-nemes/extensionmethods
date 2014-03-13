using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods.Extensions.Interfaces;

namespace ExtensionMethods.Extensions.Interfaces
{
	public static class ProductCollectionExtensions
	{
		public static IEnumerable<Product> GetAllItemsByName(this IEnumerable<IProductDataSource> productDataDources, 
			string searchTerm)
		{
			List<Product> products = new List<Product>();			
			foreach (IProductDataSource productDataSource in productDataDources)
			{
				products.AddRange(productDataSource.SearchProduct(searchTerm));
			}
			return products;
		}
	}
}
