using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class RezervariCamereClienti
{
    public long Id { get; set; }

    public long? Idrezervare { get; set; }

    public string? Nume { get; set; }

    public string? TipActIdentitate { get; set; }

    public string? NumarActIdentitate { get; set; }

    public virtual RezervariCamere? IdrezervareNavigation { get; set; }
}
