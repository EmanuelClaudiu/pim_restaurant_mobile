using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class UtilizatorDrepturi
{
    public long Id { get; set; }

    public long? IdUtilizator { get; set; }

    public string? Sectiune { get; set; }

    public string? Formular { get; set; }

    public string? Drepturi { get; set; }

    public bool? Activ { get; set; }

    public int? Prioritate { get; set; }

    public virtual Utilizatori? IdUtilizatorNavigation { get; set; }
}
