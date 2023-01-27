using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class DeliveryClienti
{
    public long Id { get; set; }

    public string? Telefon { get; set; }

    public string? Nume { get; set; }

    public string? Tip { get; set; }

    public string? TelefonClientSpalare { get; set; }

    public long? Idgestiune { get; set; }

    public virtual ICollection<DeliveryClientiAdrese> DeliveryClientiAdreses { get; } = new List<DeliveryClientiAdrese>();
}
