using CofeeShop.Models;
using System.Collections.Generic;

namespace CofeeShop.Interfaces
{
    public interface IProduct
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Product> GetAllProducts();
        Product AddProduct(Product product);
        Product UpdateProduct(int id, Product product);
        void DeleteProduct(int id);
        Product GetProductById(int id);
    }
}
