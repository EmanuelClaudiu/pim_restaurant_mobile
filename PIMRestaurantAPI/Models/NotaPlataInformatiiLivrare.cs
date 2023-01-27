using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaPlataInformatiiLivrare
{
    public long Id { get; set; }

    public long? IdnotaPlata { get; set; }

    public long? Idclient { get; set; }

    public string? Judet { get; set; }

    public string? Localitate { get; set; }

    public string? Strada { get; set; }

    public string? Numar { get; set; }

    public string? Apartament { get; set; }

    public string? Etaj { get; set; }

    public long? Idagent { get; set; }

    public double? Procent { get; set; }

    public string? Scara { get; set; }

    public long? IdcontractSpalatorie { get; set; }

    public long? IdnumarInmatriculare { get; set; }

    public virtual NotaDePlatum? IdnotaPlataNavigation { get; set; }
}
