using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorLocatie
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public long? Departament { get; set; }
}
