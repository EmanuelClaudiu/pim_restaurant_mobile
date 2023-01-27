using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorCategoriiContabile
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public string? Cont { get; set; }

    public bool? Stocabil { get; set; }
}
