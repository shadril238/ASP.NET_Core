//shadril238
using System.ComponentModel.DataAnnotations;

namespace Post_API_CRUD.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the title."), StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the description."), StringLength(300)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
