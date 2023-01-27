using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class NotaPlataProduse
{
    public long Id { get; set; }

    public long? IdnotaPlata { get; set; }

    public DateTime? DataComandaProdus { get; set; }

    public DateTime? DataTimpComandaProdus { get; set; }

    public double? PretUnitar { get; set; }

    public double? Valoare { get; set; }

    public double? Cantitate { get; set; }

    public long? Idprodus { get; set; }

    public double? Tva { get; set; }

    public string? GrupaTva { get; set; }

    public bool? HappyHour { get; set; }

    public string? NumarComanda { get; set; }

    public bool? DescarcaGestiunea { get; set; }

    public long? Idgestiune { get; set; }

    public long? Idscaun { get; set; }

    public long? Idmasa { get; set; }

    public long? Idsala { get; set; }

    public bool? GeneratPlata { get; set; }

    public long? Iduser { get; set; }

    public DateTime? DataGenerarePlata { get; set; }

    public long? IdinchidereZi { get; set; }

    public DateTime? DateTimeClientPleaca { get; set; }

    public long? IntervalHappyHour { get; set; }

    public long? IduserProdus { get; set; }

    public virtual NotaDePlatum? IdnotaPlataNavigation { get; set; }

    public virtual ICollection<NotaPlataMentiuni> NotaPlataMentiunis { get; } = new List<NotaPlataMentiuni>();

    public virtual ICollection<NotaPlataRetetar> NotaPlataRetetars { get; } = new List<NotaPlataRetetar>();
}
