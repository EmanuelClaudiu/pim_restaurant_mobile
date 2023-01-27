using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class Receptii
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? DataDocument { get; set; }

    public string? SerieDocument { get; set; }

    public string? NumarDocument { get; set; }

    public long? Idpartener { get; set; }

    public long? Iddelegat { get; set; }

    public long? Idfurnizor { get; set; }

    public DateTime? DataDocumentCorespondent { get; set; }

    public string? SerieDocumentCorespondent { get; set; }

    public string? NumarDocumentCorespondent { get; set; }

    public string? TipDocumentCorespondent { get; set; }

    public string? ContDocumentCorespondent { get; set; }

    public double? Discount { get; set; }

    public double? Adaos { get; set; }

    public string? RegimTva { get; set; }

    public bool? ReceptieIncheiata { get; set; }

    public long? Iduser { get; set; }

    public string? MachineName { get; set; }

    public bool? Finalizat { get; set; }

    public string? TipDocument { get; set; }

    public long? IdgestiuneTransfer { get; set; }

    public long? Idtransfer { get; set; }

    public DateTime? DataCreareDocument { get; set; }

    public string? DataModificareReceptie { get; set; }

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }

    public virtual ICollection<ProduseReceptie> ProduseRecepties { get; } = new List<ProduseReceptie>();
}
