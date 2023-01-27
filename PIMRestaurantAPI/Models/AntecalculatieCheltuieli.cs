using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class AntecalculatieCheltuieli
{
    public long Id { get; set; }

    public long? Idantecalculatie { get; set; }

    public string? Denumire { get; set; }

    public double? Valoare { get; set; }

    public virtual Antecalculatie? IdantecalculatieNavigation { get; set; }
}
