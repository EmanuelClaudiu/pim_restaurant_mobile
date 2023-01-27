using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SpalatorieAutovehicule
{
    public long Id { get; set; }

    public long? IdspalatorieContract { get; set; }

    public string? NumarInmatriculare { get; set; }

    public long? IdtipAutovehicul { get; set; }

    public string? Marca { get; set; }

    public bool? Activ { get; set; }

    public long? Idgestiune { get; set; }

    public virtual SpalatorieContract? IdspalatorieContractNavigation { get; set; }
}
