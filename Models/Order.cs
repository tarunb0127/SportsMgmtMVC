using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsMgmtApp.Models;

public partial class Order
{
    [Key]
    public int OrderId { get; set; }
    
    public int? EquipmentId { get; set; }

    public int? UserId { get; set; }
    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero")]
    public int? Quantity { get; set; }

    public float? TotalPrice { get; set; }

    public virtual Equipment? Equipment { get; set; }

    public virtual User? User { get; set; }
}
