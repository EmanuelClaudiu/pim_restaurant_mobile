using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class CaseMarcatGestiune
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public string? CasaMarcat { get; set; }

    public string? NumarCasa { get; set; }

    public bool? StareCasa { get; set; }

    public string? Locatie { get; set; }

    public string? DirectorRetea { get; set; }

    public string? Serie { get; set; }

    public string? Port { get; set; }

    public int? CodCasaFaraTva { get; set; }

    public string? Descriere { get; set; }

    public string? DirectorRaspuns { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }
}
