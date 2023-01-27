using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Factura
{
    public long Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Seria { get; set; }

    public string? Numar { get; set; }

    public long? Idpartener { get; set; }

    public long? Iddelegat { get; set; }

    public double? CotaTva { get; set; }

    public long? Idgestiune { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public string? TipPreluare { get; set; }

    public long? FormaPlata { get; set; }

    public bool? TrimisLaCasaMarcat { get; set; }

    public string? Observatii { get; set; }

    public DateTime? DataScadenta { get; set; }

    public string? NumarAvizInsotireMarfa { get; set; }

    public long? IdcontractSpalatorie { get; set; }

    public long? Idsubcontractant { get; set; }

    public string? TipFactura { get; set; }

    public string? ClientHotel { get; set; }

    public string? CnpclientHotel { get; set; }

    public bool? HotelFacturaPersoanaJuridica { get; set; }

    public string? HotelClientAdresa { get; set; }

    public string? HotelClientLocalitate { get; set; }

    public string? HotelClientJudet { get; set; }

    public string? NumeUtilizatorFactura { get; set; }

    public virtual ICollection<FacturaProduse> FacturaProduses { get; } = new List<FacturaProduse>();
}
