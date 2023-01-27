using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaPlataProduseStornate
{
    public long Id { get; set; }

    public long? IdnotaPlata { get; set; }

    public double? PretUnitar { get; set; }

    public double? Valoare { get; set; }

    public double? Cantitate { get; set; }

    public long? Idprodus { get; set; }

    public long? IduserProdus { get; set; }

    public DateTime? DataComandaProdus { get; set; }

    public virtual NotaDePlatum? IdnotaPlataNavigation { get; set; }
}
