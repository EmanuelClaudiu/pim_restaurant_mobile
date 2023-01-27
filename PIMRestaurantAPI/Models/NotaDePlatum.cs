using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaDePlatum
{
    public long Id { get; set; }

    public long? Idscaun { get; set; }

    public long? Idmasa { get; set; }

    public string? NumarComanda { get; set; }

    public DateTime? Data { get; set; }

    public string? Faza { get; set; }

    public double? Valoare { get; set; }

    public bool? DescarcaGestiunea { get; set; }

    public string? StareCasaMarcat { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idsala { get; set; }

    public bool? ChelnerInchis { get; set; }

    public long? Iduser { get; set; }

    public bool? GeneratPlata { get; set; }

    public DateTime? DataGenerarePlata { get; set; }

    public long? Idfactura { get; set; }

    public long? IdformaPlata { get; set; }

    public long? Idprotocol { get; set; }

    public bool? Stornare { get; set; }

    public long? IdclientFidelizare { get; set; }

    public string? TipNotaPlata { get; set; }

    public bool? SuccesNotaPlata { get; set; }

    public string? TipVanzare { get; set; }

    public long? Idclient { get; set; }

    public long? Idagent { get; set; }

    public string? CifClient { get; set; }

    public long? CasaMarcatId { get; set; }

    public bool? SeTrimiteErp { get; set; }

    public bool? TrimisErp { get; set; }

    public long? Dts { get; set; }

    public long? TransferTransart { get; set; }

    public bool? SeTrimiteServerPos { get; set; }

    public bool? TrimisServerPos { get; set; }

    public string? LocalMachine { get; set; }

    public long? IdcontractSpalatorie { get; set; }

    public string? ClientHotel { get; set; }

    public long? IdrezervareHotel { get; set; }

    public string? FisaTratament { get; set; }

    public string? TratamentNume { get; set; }

    public DateTime? TratamentData { get; set; }

    public long? TratamentNumarZile { get; set; }

    public string? TratamentObservatii { get; set; }

    public virtual ICollection<NotaDePlataFisierCasaMarcat> NotaDePlataFisierCasaMarcats { get; } = new List<NotaDePlataFisierCasaMarcat>();

    public virtual ICollection<NotaPlataInformatiiLivrare> NotaPlataInformatiiLivrares { get; } = new List<NotaPlataInformatiiLivrare>();

    public virtual ICollection<NotaPlataProduseStornate> NotaPlataProduseStornates { get; } = new List<NotaPlataProduseStornate>();

    public virtual ICollection<NotaPlataProduse> NotaPlataProduses { get; } = new List<NotaPlataProduse>();
}
