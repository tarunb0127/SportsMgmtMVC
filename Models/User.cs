using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsMgmtApp.Models;

public partial class User
{
    public int Id { get; set; }
    [Required]
    [MinLength(5, ErrorMessage = "Username must be at least 5 characters long")]
    public string? UserName { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string? Email { get; set; }
    [Required]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one letter and one number")]
    public string? Password { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
