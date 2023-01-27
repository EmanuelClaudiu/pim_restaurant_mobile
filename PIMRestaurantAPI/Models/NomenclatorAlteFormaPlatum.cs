using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorAlteFormaPlatum
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public bool? TrimiteLaCasaMarcat { get; set; }

    public bool? IncludeProtocol { get; set; }

    public bool? DescarcaStocul { get; set; }

    public bool? Activa { get; set; }

    public bool? ExportTransart { get; set; }

    public bool? GenerareFactura { get; set; }

    public double? Pozitie { get; set; }

    public int? IdplataCasaMarcat { get; set; }

    public bool? Posbancar { get; set; }
}
