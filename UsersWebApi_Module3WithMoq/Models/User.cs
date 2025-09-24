using System.ComponentModel.DataAnnotations;

namespace UsersWebApi_Module3WithMoq.Models
{
    public class User
    {
        public int Id { get; set; }

        
        public required string Name { get; set; }
        
        
        public required string Username { get; set; }

       
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; } // ⚠️ In real apps store hashed passwords!
    }
}
