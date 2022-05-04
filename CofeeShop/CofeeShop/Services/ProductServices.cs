using CofeeShop.Interfaces;
using CofeeShop.Models;
using System.Collections.Generic;

namespace CofeeShop.Services
{
    public class ProductServices : IProduct
    {
        private static List<Product> products = new()
        {
            new Product(){ Name = "Cofee", Price=150,Id=1},
            new Product(){ Name = "Tea", Price=100,Id=2}
        };
        public Product AddProduct(Product product)
        {
           products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
           return products.Find(x => x.Id == id);
        }

        public Product UpdateProduct(int id,Product product)
        {
           products[id] = product;
            return product;
        }
    }
}
