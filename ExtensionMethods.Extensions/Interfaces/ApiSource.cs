using System.Collections.Generic;

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