using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class LogoHotel
{
    public long Id { get; set; }

    public long? Idrezervare { get; set; }

    public long? IdrezervareCopil { get; set; }

    public DateTime? DataOperatiune { get; set; }

    public string? Operatiune { get; set; }

    public string? Utilizator { get; set; }

    public string? Detaliu { get; set; }

    public long? Idgestiune { get; set; }

    public string? ClientHotel { get; set; }

    public long? NumarRezervare { get; set; }
}
