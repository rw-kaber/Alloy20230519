using System.ComponentModel.DataAnnotations;

namespace Alloy20230519.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
