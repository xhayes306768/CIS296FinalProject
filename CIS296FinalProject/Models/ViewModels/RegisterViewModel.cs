using System.ComponentModel.DataAnnotations;

namespace CIS296FinalProject.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(255)]
        public string LastName { get; set; } = string.Empty; // from IdentityUser class
        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public required string ConfirmPassword { get; set; }
    }
}