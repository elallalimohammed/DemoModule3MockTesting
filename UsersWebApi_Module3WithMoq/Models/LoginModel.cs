using System.ComponentModel.DataAnnotations;

namespace UsersWebApi_Module3WithMoq.Models
{
    public class LoginModel
    {
       
        public required string Username { get; set; }

        
        public required string Password { get; set; }
    }
}
