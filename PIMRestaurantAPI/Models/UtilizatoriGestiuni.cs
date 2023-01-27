using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class UtilizatoriGestiuni
{
    public long Id { get; set; }

    public long? Idutilizator { get; set; }

    public long? Idgestiune { get; set; }

    public virtual Utilizatori? IdutilizatorNavigation { get; set; }
}
