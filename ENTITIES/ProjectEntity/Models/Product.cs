using ProjectEntity.BaseEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEntity.Models
{
   public class Product : BaseEntityID<int>
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        public int CategoryId { get; set; }
        public virtual ICollection<Category> Category { get; set; }


    }
}
