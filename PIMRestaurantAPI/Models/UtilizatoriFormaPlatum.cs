using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class UtilizatoriFormaPlatum
{
    public long Id { get; set; }

    public long? IdformaPlata { get; set; }

    public long? Idutilizator { get; set; }

    public virtual Utilizatori? IdutilizatorNavigation { get; set; }
}
