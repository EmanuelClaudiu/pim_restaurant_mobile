using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class VanzariDirecteProduse
{
    public long Id { get; set; }

    public long? IdvanzareDirecta { get; set; }

    public long? Iduser { get; set; }

    public long? Idprodus { get; set; }

    public double? PretUnitar { get; set; }

    public double? Valoare { get; set; }

    public double? Cantitate { get; set; }

    public string? MachineName { get; set; }

    public double? Discount { get; set; }

    public long? IdcodBare { get; set; }

    public virtual VanzariDirecte? IdvanzareDirectaNavigation { get; set; }
}
