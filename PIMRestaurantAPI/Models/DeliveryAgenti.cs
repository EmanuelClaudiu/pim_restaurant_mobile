using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class DeliveryAgenti
{
    public long Id { get; set; }

    public string? Agent { get; set; }

    public string? Masina { get; set; }

    public double? Procent { get; set; }

    public bool? Activ { get; set; }

    public string? Tip { get; set; }

    public long? Idgestiune { get; set; }
}
