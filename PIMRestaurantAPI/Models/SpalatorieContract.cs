using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SpalatorieContract
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? DataFacturare { get; set; }

    public DateTime? DataFinalizareContract { get; set; }

    public bool? Activ { get; set; }

    public string? NumarContract { get; set; }

    public string? TextFactura { get; set; }

    public long? Idclient { get; set; }

    public long? Idsubcontractant { get; set; }

    public bool? AdaugareNumereInmatriculare { get; set; }

    public virtual ICollection<SpalatorieAutovehicule> SpalatorieAutovehicules { get; } = new List<SpalatorieAutovehicule>();

    public virtual ICollection<SpalatorieDelegat> SpalatorieDelegats { get; } = new List<SpalatorieDelegat>();

    public virtual ICollection<SpalatoriePretContract> SpalatoriePretContracts { get; } = new List<SpalatoriePretContract>();
}
