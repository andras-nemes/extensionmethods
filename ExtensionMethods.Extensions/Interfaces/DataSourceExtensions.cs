using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions.Interfaces
{
	public static class DataSourceExtensions
	{
		public static IEnumerable<Product> SearchProduct(this IProductDataSource source, string searchTerm)
		{
			return from p in source.GetProducts() where p.Name.ToLower().IndexOf(searchTerm.ToLower()) > -1 select p;
		}

		public static string DoSomethingWithPrivateField(this Product p)
		{
			FieldInfo fieldInfo = typeof(Product).GetField("_privateField", BindingFlags.Instance | BindingFlags.NonPublic);
			string privateFieldValue = (string)fieldInfo.GetValue(p);
			return privateFieldValue;
		}
	}
}
