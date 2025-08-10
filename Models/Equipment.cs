using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsMgmtApp.Models;

public partial class Equipment
{
    public int Id { get; set; }

    [Required]
    [RegularExpression("^[a-zA-Z0-9 ]+$")]
    public string? EquipmentName { get; set; }
    [Required]
    [MinLength(3, ErrorMessage ="The category must be at least 3 characters long.")]
    public string? Category { get; set; }
    [Required]
    [MinLength(20, ErrorMessage = "The Description must be at least 20 characters long.")]
    public string? Description { get; set; }
    [Required]
    [Range(1, 1000)]
    public int? Stock { get; set; }
    [Required]
    [Range(1, 100000)]
    public float? Price { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
