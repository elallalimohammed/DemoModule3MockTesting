using System.ComponentModel.DataAnnotations;

namespace UsersWebApi_Module3WithMoq.Models
{
    // DTOs & Models
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        public required string Email { get; set; }
    }

}
