using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SpalatorieDelegat
{
    public long Id { get; set; }

    public long? IdspalatorieContract { get; set; }

    public string? NumeSiPrenume { get; set; }

    public string? Telefon { get; set; }

    public string? Adresa { get; set; }

    public bool? Activ { get; set; }

    public long? Idgestiune { get; set; }

    public virtual SpalatorieContract? IdspalatorieContractNavigation { get; set; }
}
