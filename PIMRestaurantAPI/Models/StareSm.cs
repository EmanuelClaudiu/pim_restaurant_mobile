using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class StareSm
{
    public long Id { get; set; }

    public DateTime? DataTrimitereSms { get; set; }

    public string? TrimisDe { get; set; }

    public string? NumeClient { get; set; }

    public string? TelefonClient { get; set; }

    public string? MesajSms { get; set; }

    public bool? Trimis { get; set; }

    public string? Info { get; set; }

    public string? MachineName { get; set; }

    public long? Idgestiune { get; set; }
}
