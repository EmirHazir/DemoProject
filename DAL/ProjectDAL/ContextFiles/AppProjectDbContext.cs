using Microsoft.EntityFrameworkCore;
using ProjectEntity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectDAL.ContextFiles
{
   public class AppProjectDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppProjectDbContext(DbContextOptions<AppProjectDbContext> options):base(options)
        {}

    }
}
