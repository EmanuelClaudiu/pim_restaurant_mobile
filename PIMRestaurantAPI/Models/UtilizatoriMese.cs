using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class UtilizatoriMese
{
    public long Id { get; set; }

    public long? Idutilizator { get; set; }

    public long? Idmasa { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idsala { get; set; }

    public virtual Utilizatori? IdutilizatorNavigation { get; set; }
}
