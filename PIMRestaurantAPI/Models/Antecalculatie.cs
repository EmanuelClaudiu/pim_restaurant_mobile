using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Antecalculatie
{
    public long Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Client { get; set; }

    public string? Descriere { get; set; }

    public long? Idgestiune { get; set; }

    public string? MachineName { get; set; }

    public bool? Salvat { get; set; }

    public virtual ICollection<AntecalculatieCheltuieli> AntecalculatieCheltuielis { get; } = new List<AntecalculatieCheltuieli>();

    public virtual ICollection<AntecalculatieMateriiPrime> AntecalculatieMateriiPrimes { get; } = new List<AntecalculatieMateriiPrime>();

    public virtual ICollection<AntecalculatieProduseFinite> AntecalculatieProduseFinites { get; } = new List<AntecalculatieProduseFinite>();
}
