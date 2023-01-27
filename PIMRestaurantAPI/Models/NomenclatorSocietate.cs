using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorSocietate
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public string? CodFiscal { get; set; }

    public string? RegComert { get; set; }

    public string? Judet { get; set; }

    public string? Localitate { get; set; }

    public string? Tara { get; set; }

    public string? Adresa { get; set; }

    public string? Banca { get; set; }

    public string? ContBancar { get; set; }

    public string? Web { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Telefon { get; set; }

    public string? Mobil { get; set; }

    public double? Capital { get; set; }

    public double? CotaTva { get; set; }

    public string? Comisia { get; set; }

    public string? Gestionar { get; set; }

    public string? Contabilitate { get; set; }

    public byte[]? Logo { get; set; }

    public string? TextFactura { get; set; }

    public string? TipIncasareTva { get; set; }

    public string? PunctDeLucru { get; set; }

    public string? Versiune { get; set; }

    public DateTime? OraInceput { get; set; }

    public bool? PlatitoareTva { get; set; }

    public bool? GenerareModificarePret { get; set; }

    public bool? Sincronizare { get; set; }

    public string? Banca2 { get; set; }

    public string? ContBancar2 { get; set; }

    public string? TextAntecalculatie { get; set; }
}
