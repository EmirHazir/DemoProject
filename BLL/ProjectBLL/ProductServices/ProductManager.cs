using System.Collections.Generic;
using ProjectEntity.Models;
using ProjectDAL.ContextFiles;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjectBLL.ProductServices
{
    public class ProductManager : IProductService
    {

        private AppProjectDbContext context;
        private DbSet<Product> productEntity;

        public ProductManager(AppProjectDbContext _context)
        {
            this.context = _context;
            productEntity = _context.Set<Product>();
        }


        public void DeleteProduct(int id)
        {
            Product product = GetProductById(id);
            productEntity.Remove(product);
            context.SaveChanges();

        }

        public Product GetProductById(int id)
        {
            if (id < 0)
            {
                return null;
            }
            return productEntity.SingleOrDefault(p => p.Id == id);
        }

        //public List<Category> GetProductListbyCategory(Product product)
        //{
        //    var categories = context.Categories.ToList();
        //    return categories.Where(c => c.Id == product.Id).ToList();
        //}

        public IEnumerable<Product> GetProducts()
        {
            return productEntity.AsEnumerable();
        }

        public void SaveProduct(Product product)
        {
            context.Entry(product).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
