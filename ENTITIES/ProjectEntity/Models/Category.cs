using ProjectEntity.BaseEntity;

namespace ProjectEntity.Models
{
    public class Category : BaseEntityID<int>
    {
        public string CategoryName { get; set; }
    }
}
