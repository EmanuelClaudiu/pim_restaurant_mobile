using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class TemplateSm
{
    public long Id { get; set; }

    public string? TextSmsprimireComanda { get; set; }

    public string? TextSmslivrareComanda { get; set; }

    public string? TextSmsfinalizareComanda { get; set; }

    public bool? PrimireComanda { get; set; }

    public bool? LivrareComanda { get; set; }

    public bool? FinalizareComanda { get; set; }

    public long? Idgestiune { get; set; }
}
