using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class ListaSali
{
    public long Id { get; set; }

    public long? Idgestiune { get; set; }

    public string? DenumireSala { get; set; }

    public byte[]? VizualizareSala { get; set; }

    public string? Tip { get; set; }

    public bool? Activa { get; set; }

    public string? CuloareSala { get; set; }

    public bool? ShowBackground { get; set; }

    public string? TipVanzare { get; set; }

    public double? Pozitie { get; set; }

    public bool? ModificaTvavanzare { get; set; }

    public long? CotaTvacurenta { get; set; }

    public long? CotaTvavanzare { get; set; }

    public virtual ICollection<AranjareSala> AranjareSalas { get; } = new List<AranjareSala>();

    public virtual NomenclatorGestiuni? IdgestiuneNavigation { get; set; }

    public virtual ICollection<MeseScaune> MeseScaunes { get; } = new List<MeseScaune>();
}
