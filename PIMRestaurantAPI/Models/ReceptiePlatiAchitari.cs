using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ReceptiePlatiAchitari
{
    public long Id { get; set; }

    public long? IdreceptiePlati { get; set; }

    public long? Idreceptie { get; set; }

    public double? SumaAchitata { get; set; }

    public double? ValoareReceptie { get; set; }

    public double? RestPlata { get; set; }

    public DateTime? DataReceptie { get; set; }

    public string? TipDocumentCorespondent { get; set; }

    public virtual ReceptiePlati? IdreceptiePlatiNavigation { get; set; }
}
