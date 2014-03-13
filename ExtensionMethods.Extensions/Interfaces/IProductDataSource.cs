using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions.Interfaces
{
	public interface IProductDataSource
	{
		IEnumerable<Product> GetProducts();
	}
}
