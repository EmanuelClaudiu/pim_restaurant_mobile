using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SesiuniSmsinfo
{
    public long Id { get; set; }

    public long? Idsesiune { get; set; }

    public string? Idclient { get; set; }

    public bool? Trimis { get; set; }

    public virtual SesiuniSm? IdsesiuneNavigation { get; set; }
}
