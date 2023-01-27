using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ProdusePeMasa
{
    public long Id { get; set; }

    public long? Idscaun { get; set; }

    public long? Iduser { get; set; }

    public string? NumeUser { get; set; }

    public string? Locatie { get; set; }

    public long? Idprodus { get; set; }

    public string? Um { get; set; }

    public double? PretUnitar { get; set; }

    public double? Valoare { get; set; }

    public double? Cantitate { get; set; }

    public string? ProdusText { get; set; }

    public bool? AfiseazaMentiuni { get; set; }

    public DateTime? DataComandaProdus { get; set; }

    public bool? ComandaEfectuata { get; set; }

    public string? NumeMasa { get; set; }

    public string? NumeScaun { get; set; }

    public long? Idmasa { get; set; }

    public double? Tva { get; set; }

    public string? GrupaTva { get; set; }

    public bool? HappyHour { get; set; }

    public long? Idgestiune { get; set; }

    public string? NumarComanda { get; set; }

    public long? IntervalHappyHour { get; set; }

    public long? IduserProdus { get; set; }

    public bool? GeneratNotaPlata { get; set; }

    public string? TipReteta { get; set; }

    public double? CantitatePredefinita { get; set; }

    public long? IdrezervareCamera { get; set; }

    public bool? InventarCameraMinibar { get; set; }

    public virtual ICollection<ProdusePeMasaMnetiuni> ProdusePeMasaMnetiunis { get; } = new List<ProdusePeMasaMnetiuni>();
}
