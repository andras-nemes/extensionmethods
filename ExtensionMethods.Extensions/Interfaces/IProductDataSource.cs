using System.Collections.Generic;

namespace ExtensionMethods.Extensions.Interfaces
{
    public interface IProductDataSource
    {
        IEnumerable<Product> GetProducts();
    }
}