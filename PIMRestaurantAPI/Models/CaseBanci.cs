using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class CaseBanci
{
    public long Id { get; set; }

    public string? Cont { get; set; }

    public string? Banca { get; set; }

    public string? Iban { get; set; }

    public string? SimbolBanca { get; set; }

    public string? Valuta { get; set; }
}
