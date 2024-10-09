using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace E_Learning.Dtos.User
{
    [NotMapped]
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        public string password { get; set; }
        public IFormFile? userImage { get; set; }
    }
}
