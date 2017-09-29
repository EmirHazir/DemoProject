using System.Collections.Generic;
using ProjectEntity.Models;
using ProjectDAL.ContextFiles;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjectDAL.Repositories
{
    public class ProductDAL : IProductDAL
    {
        private AppProjectDbContext context;
        private DbSet<Product> productEntity;

        public ProductDAL(AppProjectDbContext _context)
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
            if ( id < 0)
            {
                return null;
            }
            return productEntity.SingleOrDefault(p => p.Id == id);
        }

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
