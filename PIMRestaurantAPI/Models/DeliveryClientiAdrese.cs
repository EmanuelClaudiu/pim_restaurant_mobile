using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class DeliveryClientiAdrese
{
    public long Id { get; set; }

    public long? IdclientDelivery { get; set; }

    public string? Judet { get; set; }

    public string? Localitate { get; set; }

    public string? Strada { get; set; }

    public string? Numar { get; set; }

    public string? Apartament { get; set; }

    public string? Etaj { get; set; }

    public string? Scara { get; set; }

    public virtual DeliveryClienti? IdclientDeliveryNavigation { get; set; }
}
