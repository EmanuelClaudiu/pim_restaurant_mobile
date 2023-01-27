using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class HotelConfigurareScheduler
{
    public long Id { get; set; }

    public DateTime? OraPredareCamera { get; set; }

    public string? CuloareRezervare { get; set; }

    public string? CuloareCheckIn { get; set; }

    public string? CuloareCheckOut { get; set; }

    public long? IdprodusServiciuCazare { get; set; }
}
