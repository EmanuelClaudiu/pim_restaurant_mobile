using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class VanzariDirecte
{
    public long Id { get; set; }

    public string? Numar { get; set; }

    public DateTime? Data { get; set; }

    public long? Idclient { get; set; }

    public long? Idagent { get; set; }

    public long? Idgestiune { get; set; }

    public double? ValoareVanzare { get; set; }

    public double? ValoareDiscount { get; set; }

    public double? ValoareIncasata { get; set; }

    public virtual ICollection<VanzariDirecteProduse> VanzariDirecteProduses { get; } = new List<VanzariDirecteProduse>();
}
