using System.Collections.Generic;
using ProjectEntity.Models;
using ProjectDAL.ContextFiles;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjectDAL.Repositories
{
    public class CategoryDAL : ICategoryDAL
    {
        private AppProjectDbContext context;
        private DbSet<Category> categoryEntity;

        public CategoryDAL(AppProjectDbContext _context)
        {
            this.context = _context;
            categoryEntity = _context.Set<Category>();
        }

        public void DeleteCategory(int id)
        {
            Category category = GetCategoryById(id);
            categoryEntity.Remove(category);
            context.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            if ( id < 0)
            {
                return null;
            }
            return categoryEntity.SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryEntity.AsEnumerable();
        }

        public void SaveCategory(Category category)
        {
            context.Entry(category).State = EntityState.Added;
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
