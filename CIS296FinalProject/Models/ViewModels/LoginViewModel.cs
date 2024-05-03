using System.ComponentModel.DataAnnotations;


namespace CIS296FinalProject.Models
{ 

public class LoginViewModel
{
    [Required(ErrorMessage = "Please enter a username.")]
    [StringLength(255)]
    public required string Username { get; set; }

    [Required(ErrorMessage = "Please enter a password.")]
    [StringLength(255)]
    public required string Password { get; set; }

    public string? ReturnUrl { get; set; }

    public bool RememberMe { get; set; }
   }

}
