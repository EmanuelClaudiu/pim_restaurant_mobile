using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Produse
{
    public long Id { get; set; }

    public string? Categorie { get; set; }

    public string? Denumire { get; set; }

    public string? Cod { get; set; }

    public double? PretCumparare { get; set; }

    public double? PretVanzare { get; set; }

    public long? Um { get; set; }

    public long? Grupa { get; set; }

    public long? Locatie { get; set; }

    public long? CategorieContabila { get; set; }

    public long? Tva { get; set; }

    public double? StocMinim { get; set; }

    public string? Stare { get; set; }

    public bool? AfiseazaMentiuni { get; set; }

    public double? CantitateDisponibila { get; set; }

    public string? ListaGestiuni { get; set; }

    public string? TipReteta { get; set; }

    public bool? DiscountPos { get; set; }

    public bool? AfisareVanzare { get; set; }

    public virtual ICollection<PretProdusGestiune> PretProdusGestiunes { get; } = new List<PretProdusGestiune>();

    public virtual ICollection<ProdusCantitatiPredefinite> ProdusCantitatiPredefinites { get; } = new List<ProdusCantitatiPredefinite>();

    public virtual ICollection<ProdusDescriere> ProdusDescrieres { get; } = new List<ProdusDescriere>();

    public virtual ICollection<ProdusRetete> ProdusRetetes { get; } = new List<ProdusRetete>();

    public virtual ICollection<ProduseCoduriBare> ProduseCoduriBares { get; } = new List<ProduseCoduriBare>();
}
