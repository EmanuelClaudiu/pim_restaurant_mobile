using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class TransArtConnector
{
    public long Id { get; set; }

    public string? Firma { get; set; }

    public string? Utilizator { get; set; }

    public string? IpwebService { get; set; }

    public string? VersiuneWebServive { get; set; }

    public DateTime? TimpImport { get; set; }

    public DateTime? TimpExport { get; set; }

    public string? Parola { get; set; }

    public string? TertInfoAprovizionare { get; set; }

    public string? ProdusHhfidelizare { get; set; }

    public string? Sursa { get; set; }
}
