using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaDePlataFisierCasaMarcat
{
    public long Id { get; set; }

    public long? IdnotaPlata { get; set; }

    public string? NumeFisier { get; set; }

    public DateTime? DataCreareFisier { get; set; }

    public string? Utilizator { get; set; }

    public string? MachineName { get; set; }

    public string? TextFisier { get; set; }

    public virtual NotaDePlatum? IdnotaPlataNavigation { get; set; }
}
