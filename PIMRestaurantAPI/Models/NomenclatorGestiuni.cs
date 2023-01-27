using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorGestiuni
{
    public long Id { get; set; }

    public string? Denumire { get; set; }

    public string? PretulContineTva { get; set; }

    public string? CuAdaos { get; set; }

    public bool? Activa { get; set; }

    public long? NumarNotaPlata { get; set; }

    public string? SerieReceptie { get; set; }

    public long? NumarReceptie { get; set; }

    public string? ComisiaReceptieNume1 { get; set; }

    public string? ComisiaReceptieNume2 { get; set; }

    public string? PrimitInGestiuneNume { get; set; }

    public string? SerieTransfer { get; set; }

    public long? NumarTransfer { get; set; }

    public string? SerieBonConsum { get; set; }

    public long? NumarBonConsum { get; set; }

    public bool? InLucru { get; set; }

    public string? MachineName { get; set; }

    public long? IduserBlocat { get; set; }

    public long? IdinregistrareErr { get; set; }

    public string? TipOperatiuneErr { get; set; }

    public long? IdinregistrareTransferErr { get; set; }

    public DateTime? DataErr { get; set; }

    public string? NotaPlataRestaurant { get; set; }

    public string? NotaPlataDenumire { get; set; }

    public string? NotaPlataAdresa { get; set; }

    public string? NotaPlataMesaj1 { get; set; }

    public string? NotaPlataMesaj2 { get; set; }

    public string? Mentiuni { get; set; }

    public string? SerieFactura { get; set; }

    public long? NumarFactura { get; set; }

    public long? IdgestiuneDts { get; set; }

    public bool? GestiuneHotel { get; set; }

    public long? IdgestiuneHotelAtasata { get; set; }

    public virtual ICollection<CarduriFidelizare> CarduriFidelizares { get; } = new List<CarduriFidelizare>();

    public virtual ICollection<CaseMarcatGestiune> CaseMarcatGestiunes { get; } = new List<CaseMarcatGestiune>();

    public virtual ICollection<FidelizareGrupe> FidelizareGrupes { get; } = new List<FidelizareGrupe>();

    public virtual ICollection<ListaSali> ListaSalis { get; } = new List<ListaSali>();

    public virtual ICollection<NomenclatorHappyHour> NomenclatorHappyHours { get; } = new List<NomenclatorHappyHour>();

    public virtual ICollection<NomenclatorSetariDiscount> NomenclatorSetariDiscounts { get; } = new List<NomenclatorSetariDiscount>();

    public virtual ICollection<PretProdusGestiune> PretProdusGestiunes { get; } = new List<PretProdusGestiune>();

    public virtual ICollection<Receptii> Receptiis { get; } = new List<Receptii>();

    public virtual ICollection<SetariImprimantaLocatie> SetariImprimantaLocaties { get; } = new List<SetariImprimantaLocatie>();

    public virtual ICollection<SetariImprimantaRapoarte> SetariImprimantaRapoartes { get; } = new List<SetariImprimantaRapoarte>();

    public virtual ICollection<TipAranjareGestiune> TipAranjareGestiunes { get; } = new List<TipAranjareGestiune>();
}
