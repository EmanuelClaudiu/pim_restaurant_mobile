using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorGrupa
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public long? TransartRamuraLocatie { get; set; }
}
