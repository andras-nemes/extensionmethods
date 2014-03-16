using System.Collections.Generic;

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