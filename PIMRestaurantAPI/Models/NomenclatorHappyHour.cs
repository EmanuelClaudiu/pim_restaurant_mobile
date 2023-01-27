using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NomenclatorHappyHour
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public string? Denumire { get; set; }

    public DateTime? OraInceput { get; set; }

    public DateTime? OraSfarsit { get; set; }

    public double? Discount { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }

    public virtual ICollection<NomenclatorProduseHappyHour> NomenclatorProduseHappyHours { get; } = new List<NomenclatorProduseHappyHour>();
}
