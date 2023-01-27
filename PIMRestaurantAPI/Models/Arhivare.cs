using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Arhivare
{
    public long Id { get; set; }

    public long? Idprodus { get; set; }

    public double? PretAchizitie { get; set; }

    public double? PretGestiune { get; set; }

    public double? Adaos { get; set; }

    public double? Discount { get; set; }

    public double? Tva { get; set; }

    public string? Um { get; set; }

    public string? Grupa { get; set; }

    public string? ContContabil { get; set; }

    public long? Idgestiune { get; set; }

    public double? PretAchizitieIntreg { get; set; }

    public double? AdaosComercial { get; set; }

    public double? CantitateDisponibila { get; set; }
}
