using System.Collections.Generic;

namespace ExtensionMethods.Extensions.Interfaces
{
    public class DatabaseSource : DatabaseSourceBase, IProductDataSource
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>() { new Product() { Id = 1, Name = "First" }, new Product() { Id = 2, Name = "Second" } };
        }
    }
}