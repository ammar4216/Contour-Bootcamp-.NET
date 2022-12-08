using System.ComponentModel.DataAnnotations;

namespace AuthenticationWithJWT.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required]
        public string MyRole { get; set; }
    }
}
