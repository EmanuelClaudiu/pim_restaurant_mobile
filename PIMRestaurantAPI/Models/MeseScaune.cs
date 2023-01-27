using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class MeseScaune
{
    public long Id { get; set; }

    public long? Idsala { get; set; }

    public long? Idcopil { get; set; }

    public long? Idgestiune { get; set; }

    public string? Name { get; set; }

    public bool? Activa { get; set; }

    public string? Tip { get; set; }

    public string? ToolTip { get; set; }

    public long? UtilizatorComanda { get; set; }

    public long? BonConsum { get; set; }

    public long? NotaDePlata { get; set; }

    public long? AcumPeScaun { get; set; }

    public string? Machinename { get; set; }

    public long? IdnotaPlataCreata { get; set; }

    public string? RezervareClient { get; set; }

    public long? NumarLocuri { get; set; }

    public double? PretPerNoapte { get; set; }

    public string? StatusCamera { get; set; }

    public virtual ListaSali? IdsalaNavigation { get; set; }

    public virtual ICollection<Locatii> Locatiis { get; } = new List<Locatii>();

    public virtual ICollection<ProduseInventarPeCamera> ProduseInventarPeCameras { get; } = new List<ProduseInventarPeCamera>();

    public virtual ICollection<ProduseMiniBarPeCamera> ProduseMiniBarPeCameras { get; } = new List<ProduseMiniBarPeCamera>();

    public virtual ICollection<ScaunClientDeliveryAlte> ScaunClientDeliveryAltes { get; } = new List<ScaunClientDeliveryAlte>();

    public virtual ICollection<StariAtasateCamera> StariAtasateCameras { get; } = new List<StariAtasateCamera>();
}
