using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class AntecalculatieMateriiPrime
{
    public long Id { get; set; }

    public long? Idantecalculatie { get; set; }

    public long? Idprodus { get; set; }

    public string? Denumire { get; set; }

    public double? Cantitate { get; set; }

    public string? Um { get; set; }

    public double? PretAchizitie { get; set; }

    public double? ValoareAchizitie { get; set; }

    public double? Adaos { get; set; }

    public double? PretGestiune { get; set; }

    public double? ValoareGestiune { get; set; }

    public double? Tva { get; set; }

    public double? ValoareAdaos { get; set; }

    public virtual Antecalculatie? IdantecalculatieNavigation { get; set; }
}
