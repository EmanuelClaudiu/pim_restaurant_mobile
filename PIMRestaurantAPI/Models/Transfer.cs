using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Transfer
{
    public long Id { get; set; }

    public DateTime? DataTransfer { get; set; }

    public string? NumarTranfer { get; set; }

    public string? SerieTransfer { get; set; }

    public long? IdgestiuneaTransfer { get; set; }

    public long? IdgestiuneaDestinatie { get; set; }

    public double? Tva { get; set; }

    public bool? Finalizat { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public string? Observatii { get; set; }

    public DateTime? DataCreareDocument { get; set; }

    public virtual ICollection<TransferProduse> TransferProduses { get; } = new List<TransferProduse>();
}
