using System;
using System.Collections.Generic;

namespace PIMRestaurantAPI.Models;

public partial class RezervariCamere
{
    public long Id { get; set; }

    public long? Idscaun { get; set; }

    public string? Nume { get; set; }

    public string? Adresa { get; set; }

    public string? Judet { get; set; }

    public string? Oras { get; set; }

    public string? CodZip { get; set; }

    public string? Tara { get; set; }

    public string? ActIdentitate { get; set; }

    public string? NumarIdentitate { get; set; }

    public string? Nationalitatea { get; set; }

    public string? Sex { get; set; }

    public double? SumaAvans { get; set; }

    public double? NumarNopti { get; set; }

    public long? NumarAdulti { get; set; }

    public long? NumarCopii { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Email { get; set; }

    public string? TelefonFix { get; set; }

    public string? TelefonMobil { get; set; }

    public string? Fax { get; set; }

    public string? Web { get; set; }

    public string? ObservatiiCheckIn { get; set; }

    public string? ObservatiiCheckOut { get; set; }

    public int? Stare { get; set; }

    public string? CreatDe { get; set; }

    public string? ModificatDe { get; set; }

    public long? Idgestiune { get; set; }

    public DateTime? StartTimeScheduler { get; set; }

    public DateTime? EndTimeScheduler { get; set; }

    public double? PretPerNoapte { get; set; }

    public int? NumarLocuri { get; set; }

    public string? SeriaIdentitate { get; set; }

    public string? IdentitateEleibaratDe { get; set; }

    public DateTime? DataNasterii { get; set; }

    public string? LoculNasterii { get; set; }

    public string? MachineName { get; set; }

    public long? NumarRezervare { get; set; }

    public long? Idfactura { get; set; }

    public string? Cnp { get; set; }

    public long? IdnotaPlata { get; set; }

    public long? Idtip { get; set; }

    public bool? MicDejun { get; set; }

    public string? SerieBilet { get; set; }

    public string? NumarBilet { get; set; }

    public DateTime? DataPrezenta { get; set; }

    public string? SerieCartela { get; set; }

    public string? BeneficiarTara { get; set; }

    public string? BeneficiarJudet { get; set; }

    public string? BeneficiarOras { get; set; }

    public string? BeneficiarAdresa { get; set; }

    public string? BeneficiarActIdentitate { get; set; }

    public string? BeneficiarActIdentitateSeria { get; set; }

    public string? BeneficiarActIdentitateNumar { get; set; }

    public string? BeneficiarActIdentitateCnp { get; set; }

    public string? BeneficiarActIdentitateEliberatDe { get; set; }

    public string? BeneficiarNume { get; set; }

    public string? FisaTratament { get; set; }

    public string? Agentie { get; set; }

    public string? Voucher { get; set; }

    public virtual ICollection<RezervariCamereClienti> RezervariCamereClientis { get; } = new List<RezervariCamereClienti>();
}
