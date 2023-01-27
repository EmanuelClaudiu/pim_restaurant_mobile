using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class SesiuniSm
{
    public long Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Subiect { get; set; }

    public string? TemplateSms { get; set; }

    public long? NumeUser { get; set; }

    public long? Idgestiune { get; set; }

    public virtual ICollection<SesiuniSmsinfo> SesiuniSmsinfos { get; } = new List<SesiuniSmsinfo>();
}
