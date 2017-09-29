using ProjectEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL.Repositories
{
   public interface ICategoryDAL 
    {
        void SaveCategory(Category category);
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int id);
        void DeleteCategory(int id);
        void UpdateCategory(Category category);

    }
}
