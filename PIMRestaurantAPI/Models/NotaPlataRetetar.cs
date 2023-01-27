using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaPlataRetetar
{
    public long Id { get; set; }

    public long? IdprodusNotaPlata { get; set; }

    public DateTime? DataComandaProdus { get; set; }

    public double? Cantitate { get; set; }

    public double? Tva { get; set; }

    public string? GrupaTva { get; set; }

    public long? Idmaterial { get; set; }

    public string? NumarComanda { get; set; }

    public bool? DescarcaGestiunea { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idsala { get; set; }

    public long? Idmasa { get; set; }

    public long? Idscaun { get; set; }

    public double? PretVanzare { get; set; }

    public double? Valoare { get; set; }

    public long? Iduser { get; set; }

    public long? IdprodusFinit { get; set; }

    public virtual NotaPlataProduse? IdprodusNotaPlataNavigation { get; set; }
}
