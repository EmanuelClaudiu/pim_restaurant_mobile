using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class CarduriFidelizare
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public long? IdgrupaFidelizare { get; set; }

    public string? NumarCard { get; set; }

    public string? Cnp { get; set; }

    public string? Nume { get; set; }

    public string? Prenume { get; set; }

    public string? Telefon { get; set; }

    public string? Email { get; set; }

    public string? Adresa { get; set; }

    public bool? CardActiv { get; set; }

    public byte[]? Poza { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
