﻿using System.Collections.Generic;

namespace ExtensionMethods.Extensions.Interfaces
{
    public class FileSource : FileSourceBase, IProductDataSource
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>() { new Product() { Id = 3, Name = "Third" }, new Product() { Id = 4, Name = "Fourth" } };
        }
    }
}