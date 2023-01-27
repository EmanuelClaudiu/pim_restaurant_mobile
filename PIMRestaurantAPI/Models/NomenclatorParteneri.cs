using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorParteneri
{
    public long Id { get; set; }

    public string? CodFiscal { get; set; }

    public string? Denumire { get; set; }

    public string? NumarRegComert { get; set; }

    public string? Tara { get; set; }

    public string? Adresa { get; set; }

    public string? Localitate { get; set; }

    public string? Judet { get; set; }

    public string? Banca { get; set; }

    public string? Cont { get; set; }

    public string? Telefon { get; set; }

    public string? Fax { get; set; }

    public string? Informatii { get; set; }

    public string? Email { get; set; }

    public string? AnulInfintarii { get; set; }

    public string? CodCaen { get; set; }

    public string? TipulDeActivitate { get; set; }

    public string? CodPostal { get; set; }

    public bool? Client { get; set; }

    public bool? Furnizor { get; set; }
}
