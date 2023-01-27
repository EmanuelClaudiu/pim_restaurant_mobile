using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class RezervariMese
{
    public long Id { get; set; }

    public long? Idmasa { get; set; }

    public string? NumeClient { get; set; }

    public DateTime? Data { get; set; }

    public DateTime? IntervalInceput { get; set; }

    public DateTime? IntervalSfarsit { get; set; }

    public string? Telefon { get; set; }

    public string? Observatii { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idsala { get; set; }
}
