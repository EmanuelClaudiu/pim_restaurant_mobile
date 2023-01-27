using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class AntecalculatieProduseFinite
{
    public long Id { get; set; }

    public long? Idantecalculatie { get; set; }

    public long? Idprodus { get; set; }

    public string? Denumire { get; set; }

    public string? Um { get; set; }

    public double? Pret { get; set; }

    public double? Valoare { get; set; }

    public double? Cantitate { get; set; }

    public double? Adaos { get; set; }

    public virtual Antecalculatie? IdantecalculatieNavigation { get; set; }
}
