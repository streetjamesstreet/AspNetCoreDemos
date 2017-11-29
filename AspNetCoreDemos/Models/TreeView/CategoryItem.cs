using System.Collections.Generic;

namespace AspNetCoreDemos.Models
{
    public class CategoryItem
    {
        public string CategoryName { get; set; }
        public List<SubCategoryItem> SubCategories { get; set; }
    }
}