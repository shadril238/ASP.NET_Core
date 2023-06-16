using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.DTOs
{
    public class UserDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
