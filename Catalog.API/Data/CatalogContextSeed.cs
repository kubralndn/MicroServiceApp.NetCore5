using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            };
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>()
           {
               new Product()
               {
                   Name="Iphone 11",
                   Summary="gfdgdfg",
                   ImageFile="product-1.png",
                   Price=150.99M,
                   Category="Smart Phone"

               },
                new Product()
               {
                   Name="Xiomi mi 8 Lite",
                   Summary="gfdgfgg",
                   ImageFile="product-2.png",
                   Price=350.99M,
                   Category="Smart Phone"

               },
                 new Product()
               {
                   Name="LG",
                   Summary="vbvvvvv",
                   ImageFile="product-3.png",
                   Price=950.99M,
                   Category="Smart Phone"

               },
           };

        }
    }
}
