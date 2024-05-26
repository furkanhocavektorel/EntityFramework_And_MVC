using Mvc.Models.entity;

namespace Mvc.Models.vmodel
{
    public class IndexVıew
    {
        public List<Product> products { get; set; }
        public List<Category> categories { get; set; }
        public int? activeCategory;
    }
}
