using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Locatii
{
    public long Id { get; set; }

    public long? IdmeseScaune { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idaranjare { get; set; }

    public long? Idsala { get; set; }

    public long? IdsalaAranjare { get; set; }

    public long? LocatieX { get; set; }

    public long? LocatieY { get; set; }

    public long? SizeX { get; set; }

    public long? SizeY { get; set; }

    public bool? Activ { get; set; }

    public virtual MeseScaune? IdmeseScauneNavigation { get; set; }
}
