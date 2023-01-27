using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class FacturaProduse
{
    public long Id { get; set; }

    public long? Idfactura { get; set; }

    public double? Cantitate { get; set; }

    public double? Valoare { get; set; }

    public string? ProdusText { get; set; }

    public string? GrupaTva { get; set; }

    public string? Grupa { get; set; }

    public double? PretUnitar { get; set; }

    public long? Idprodus { get; set; }

    public string? NumarComanda { get; set; }

    public string? Um { get; set; }

    public double? Tva { get; set; }

    public double? ValoareTva { get; set; }

    public double? ValoareFaraTva { get; set; }

    public bool? TrimisCasa { get; set; }

    public long? IdnotaPlata { get; set; }

    public long? Idgestiune { get; set; }

    public double? PretUnitarFaraTva { get; set; }

    public virtual Factura? IdfacturaNavigation { get; set; }
}
