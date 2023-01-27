using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaPlataMentiuni
{
    public long Id { get; set; }

    public long? IdprodusNotaPlata { get; set; }

    public string? Mentiune { get; set; }

    public bool? ComandaEfectuata { get; set; }

    public virtual NotaPlataProduse? IdprodusNotaPlataNavigation { get; set; }
}
