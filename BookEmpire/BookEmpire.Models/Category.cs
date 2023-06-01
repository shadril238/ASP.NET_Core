using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookEmpire.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new List<Product>();
        }
    }
}
