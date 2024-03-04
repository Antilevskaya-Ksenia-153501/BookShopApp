using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookShopWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(40)]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage ="Display Order must be between 0-100")]
        public int DisplayOrder { get; set; }
    }
}
