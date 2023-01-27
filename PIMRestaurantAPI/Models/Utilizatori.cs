using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Utilizatori
{
    public long Id { get; set; }

    public string? NumeUtilizator { get; set; }

    public string? ParolaUtilizator { get; set; }

    public string? Card { get; set; }

    public bool? UtilizatorActiv { get; set; }

    public bool? Storno { get; set; }

    public string? Tip { get; set; }

    public bool? StorneazaOriceProdus { get; set; }

    public long? TimpDelogare { get; set; }

    public bool? VerificaStocDataVanzarii { get; set; }

    public bool? AccesFrontOffice { get; set; }

    public bool? AccesBackOffice { get; set; }

    public bool? ListareNotaPlata { get; set; }

    public bool? ListareBonBarBuc { get; set; }

    public bool? TransferClientPleacaLaStornare { get; set; }

    public bool? VanzareRapida { get; set; }

    public bool? StornareProduseNotaPlata { get; set; }

    public bool? AccesRapoarteParola { get; set; }

    public bool? TrimiteSms { get; set; }

    public bool? AfisareFormularClientoDelivery { get; set; }

    public virtual ICollection<LayoutGrid> LayoutGrids { get; } = new List<LayoutGrid>();

    public virtual ICollection<UtilizatorDrepturi> UtilizatorDrepturis { get; } = new List<UtilizatorDrepturi>();

    public virtual ICollection<UtilizatoriFormaPlatum> UtilizatoriFormaPlata { get; } = new List<UtilizatoriFormaPlatum>();

    public virtual ICollection<UtilizatoriGestiuni> UtilizatoriGestiunis { get; } = new List<UtilizatoriGestiuni>();

    public virtual ICollection<UtilizatoriMese> UtilizatoriMeses { get; } = new List<UtilizatoriMese>();
}
