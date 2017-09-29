using ProjectEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL.Repositories
{
   public interface IProductDAL 
    {
        void SaveProduct(Product product);
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);

    }
}
