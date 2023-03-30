using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Please Enter All Fields")]
        [StringLength(15, MinimumLength = 5, ErrorMessage= "Username must be between 5 to 15 characters.")]
        public string? UserName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please Enter All Fields")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 to 20 characters.")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please Enter All Fields")]
        public string? VerifyPassword { get; set; }
      


    }
}
