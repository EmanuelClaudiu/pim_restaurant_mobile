using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PIMRestaurantAPI.Models;

public partial class PossistemContext : DbContext
{
    public PossistemContext()
    {
    }

    public PossistemContext(DbContextOptions<PossistemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Antecalculatie> Antecalculaties { get; set; }

    public virtual DbSet<AntecalculatieCheltuieli> AntecalculatieCheltuielis { get; set; }

    public virtual DbSet<AntecalculatieMateriiPrime> AntecalculatieMateriiPrimes { get; set; }

    public virtual DbSet<AntecalculatieProduseFinite> AntecalculatieProduseFinites { get; set; }

    public virtual DbSet<AranjareSala> AranjareSalas { get; set; }

    public virtual DbSet<AranjariGestiuni> AranjariGestiunis { get; set; }

    public virtual DbSet<Arhivare> Arhivares { get; set; }

    public virtual DbSet<BonConsum> BonConsums { get; set; }

    public virtual DbSet<BonConsumProduse> BonConsumProduses { get; set; }

    public virtual DbSet<CarduriFidelizare> CarduriFidelizares { get; set; }

    public virtual DbSet<CaseBanci> CaseBancis { get; set; }

    public virtual DbSet<CaseMarcatGestiune> CaseMarcatGestiunes { get; set; }

    public virtual DbSet<Delegati> Delegatis { get; set; }

    public virtual DbSet<DeliveryAgenti> DeliveryAgentis { get; set; }

    public virtual DbSet<DeliveryClienti> DeliveryClientis { get; set; }

    public virtual DbSet<DeliveryClientiAdrese> DeliveryClientiAdreses { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FacturaProduse> FacturaProduses { get; set; }

    public virtual DbSet<FidelizareGrupe> FidelizareGrupes { get; set; }

    public virtual DbSet<FidelizareProduse> FidelizareProduses { get; set; }

    public virtual DbSet<GestiuniActualizare> GestiuniActualizares { get; set; }

    public virtual DbSet<HotelConfigurareScheduler> HotelConfigurareSchedulers { get; set; }

    public virtual DbSet<IesiriReceptie> IesiriRecepties { get; set; }

    public virtual DbSet<InchidereZi> InchidereZis { get; set; }

    public virtual DbSet<InchidereZiDt> InchidereZiDts { get; set; }

    public virtual DbSet<InchidereZiproduseDt> InchidereZiproduseDts { get; set; }

    public virtual DbSet<InfoMesaje> InfoMesajes { get; set; }

    public virtual DbSet<Inventar> Inventars { get; set; }

    public virtual DbSet<InventarProduse> InventarProduses { get; set; }

    public virtual DbSet<LayoutGrid> LayoutGrids { get; set; }

    public virtual DbSet<ListaSali> ListaSalis { get; set; }

    public virtual DbSet<Locatii> Locatiis { get; set; }

    public virtual DbSet<LogoHotel> LogoHotels { get; set; }

    public virtual DbSet<Mentiuni> Mentiunis { get; set; }

    public virtual DbSet<MeseScaune> MeseScaunes { get; set; }

    public virtual DbSet<NomenclatorAlteFormaPlatum> NomenclatorAlteFormaPlata { get; set; }

    public virtual DbSet<NomenclatorCategoriiContabile> NomenclatorCategoriiContabiles { get; set; }

    public virtual DbSet<NomenclatorGestiuni> NomenclatorGestiunis { get; set; }

    public virtual DbSet<NomenclatorGrupa> NomenclatorGrupas { get; set; }

    public virtual DbSet<NomenclatorHappyHour> NomenclatorHappyHours { get; set; }

    public virtual DbSet<NomenclatorJudete> NomenclatorJudetes { get; set; }

    public virtual DbSet<NomenclatorLocatie> NomenclatorLocaties { get; set; }

    public virtual DbSet<NomenclatorParteneri> NomenclatorParteneris { get; set; }

    public virtual DbSet<NomenclatorProduseHappyHour> NomenclatorProduseHappyHours { get; set; }

    public virtual DbSet<NomenclatorSetariDiscount> NomenclatorSetariDiscounts { get; set; }

    public virtual DbSet<NomenclatorSocietate> NomenclatorSocietates { get; set; }

    public virtual DbSet<NomenclatorTari> NomenclatorTaris { get; set; }

    public virtual DbSet<NomenclatorTva> NomenclatorTvas { get; set; }

    public virtual DbSet<NomenclatorUm> NomenclatorUms { get; set; }

    public virtual DbSet<NotaDePlataFisierCasaMarcat> NotaDePlataFisierCasaMarcats { get; set; }

    public virtual DbSet<NotaDePlatum> NotaDePlata { get; set; }

    public virtual DbSet<NotaPlataInformatiiLivrare> NotaPlataInformatiiLivrares { get; set; }

    public virtual DbSet<NotaPlataMentiuni> NotaPlataMentiunis { get; set; }

    public virtual DbSet<NotaPlataProduse> NotaPlataProduses { get; set; }

    public virtual DbSet<NotaPlataProduseStornate> NotaPlataProduseStornates { get; set; }

    public virtual DbSet<NotaPlataRetetar> NotaPlataRetetars { get; set; }

    public virtual DbSet<PimPosHash> PimPosHashes { get; set; }

    public virtual DbSet<PretProdusGestiune> PretProdusGestiunes { get; set; }

    public virtual DbSet<ProdusCantitatiPredefinite> ProdusCantitatiPredefinites { get; set; }

    public virtual DbSet<ProdusDescriere> ProdusDescrieres { get; set; }

    public virtual DbSet<ProdusRetete> ProdusRetetes { get; set; }

    public virtual DbSet<Produse> Produses { get; set; }

    public virtual DbSet<ProduseCoduriBare> ProduseCoduriBares { get; set; }

    public virtual DbSet<ProduseInventarPeCamera> ProduseInventarPeCameras { get; set; }

    public virtual DbSet<ProduseMiniBarPeCamera> ProduseMiniBarPeCameras { get; set; }

    public virtual DbSet<ProdusePeMasa> ProdusePeMasas { get; set; }

    public virtual DbSet<ProdusePeMasaMnetiuni> ProdusePeMasaMnetiunis { get; set; }

    public virtual DbSet<ProduseReceptie> ProduseRecepties { get; set; }

    public virtual DbSet<ProduseReceptieSchimbarePret> ProduseReceptieSchimbarePrets { get; set; }

    public virtual DbSet<ProduseVanzareDirectum> ProduseVanzareDirecta { get; set; }

    public virtual DbSet<Protocol> Protocols { get; set; }

    public virtual DbSet<ReceptiePlati> ReceptiePlatis { get; set; }

    public virtual DbSet<ReceptiePlatiAchitari> ReceptiePlatiAchitaris { get; set; }

    public virtual DbSet<Receptii> Receptiis { get; set; }

    public virtual DbSet<RezervariCamere> RezervariCameres { get; set; }

    public virtual DbSet<RezervariCamereClienti> RezervariCamereClientis { get; set; }

    public virtual DbSet<RezervariCamereTip> RezervariCamereTips { get; set; }

    public virtual DbSet<RezervariCamereTipProduse> RezervariCamereTipProduses { get; set; }

    public virtual DbSet<RezervariMese> RezervariMeses { get; set; }

    public virtual DbSet<ScaunClientDeliveryAlte> ScaunClientDeliveryAltes { get; set; }

    public virtual DbSet<SchimbarePret> SchimbarePrets { get; set; }

    public virtual DbSet<SchimbarePretProduse> SchimbarePretProduses { get; set; }

    public virtual DbSet<SesiuniSm> SesiuniSms { get; set; }

    public virtual DbSet<SesiuniSmsinfo> SesiuniSmsinfos { get; set; }

    public virtual DbSet<SetariImprimantaLocatie> SetariImprimantaLocaties { get; set; }

    public virtual DbSet<SetariImprimantaRapoarte> SetariImprimantaRapoartes { get; set; }

    public virtual DbSet<SpalatorieAutovehicule> SpalatorieAutovehicules { get; set; }

    public virtual DbSet<SpalatorieContract> SpalatorieContracts { get; set; }

    public virtual DbSet<SpalatorieDelegat> SpalatorieDelegats { get; set; }

    public virtual DbSet<SpalatoriePretContract> SpalatoriePretContracts { get; set; }

    public virtual DbSet<SpalatorieTipAutovehicul> SpalatorieTipAutovehiculs { get; set; }

    public virtual DbSet<StareSm> StareSms { get; set; }

    public virtual DbSet<StariAtasateCamera> StariAtasateCameras { get; set; }

    public virtual DbSet<StatusCamera> StatusCameras { get; set; }

    public virtual DbSet<TemplateSm> TemplateSms { get; set; }

    public virtual DbSet<TipAranjareGestiune> TipAranjareGestiunes { get; set; }

    public virtual DbSet<TransArtConnector> TransArtConnectors { get; set; }

    public virtual DbSet<TransArtConnectorGestiuni> TransArtConnectorGestiunis { get; set; }

    public virtual DbSet<TransArtHash> TransArtHashes { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    public virtual DbSet<TransferProduse> TransferProduses { get; set; }

    public virtual DbSet<UtilizatorDrepturi> UtilizatorDrepturis { get; set; }

    public virtual DbSet<Utilizatori> Utilizatoris { get; set; }

    public virtual DbSet<UtilizatoriFormaPlatum> UtilizatoriFormaPlata { get; set; }

    public virtual DbSet<UtilizatoriGestiuni> UtilizatoriGestiunis { get; set; }

    public virtual DbSet<UtilizatoriMese> UtilizatoriMeses { get; set; }

    public virtual DbSet<VanzariDirecte> VanzariDirectes { get; set; }

    public virtual DbSet<VanzariDirecteProduse> VanzariDirecteProduses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=46.214.70.41,33322;Initial Catalog=possistem;Persist Security Info=True;User ID=sa;Password=pimpos;Trusted_Connection=false;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Antecalculatie>(entity =>
        {
            entity.ToTable("Antecalculatie");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Client)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Descriere)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.MachineName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<AntecalculatieCheltuieli>(entity =>
        {
            entity.ToTable("AntecalculatieCheltuieli");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idantecalculatie).HasColumnName("IDAntecalculatie");

            entity.HasOne(d => d.IdantecalculatieNavigation).WithMany(p => p.AntecalculatieCheltuielis)
                .HasForeignKey(d => d.Idantecalculatie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AntecalculatieCheltuieli_Antecalculatie");
        });

        modelBuilder.Entity<AntecalculatieMateriiPrime>(entity =>
        {
            entity.ToTable("AntecalculatieMateriiPrime");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idantecalculatie).HasColumnName("IDAntecalculatie");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");

            entity.HasOne(d => d.IdantecalculatieNavigation).WithMany(p => p.AntecalculatieMateriiPrimes)
                .HasForeignKey(d => d.Idantecalculatie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AntecalculatieMateriiPrime_Antecalculatie");
        });

        modelBuilder.Entity<AntecalculatieProduseFinite>(entity =>
        {
            entity.ToTable("AntecalculatieProduseFinite");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idantecalculatie).HasColumnName("IDAntecalculatie");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");

            entity.HasOne(d => d.IdantecalculatieNavigation).WithMany(p => p.AntecalculatieProduseFinites)
                .HasForeignKey(d => d.Idantecalculatie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AntecalculatieProduseFinite_Antecalculatie");
        });

        modelBuilder.Entity<AranjareSala>(entity =>
        {
            entity.ToTable("AranjareSala");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idaranjare).HasColumnName("IDAranjare");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");

            entity.HasOne(d => d.IdsalaNavigation).WithMany(p => p.AranjareSalas)
                .HasForeignKey(d => d.Idsala)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AranjareSala_ListaSali");
        });

        modelBuilder.Entity<AranjariGestiuni>(entity =>
        {
            entity.ToTable("AranjariGestiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Arhivare>(entity =>
        {
            entity.ToTable("Arhivare");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContContabil)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Grupa)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<BonConsum>(entity =>
        {
            entity.ToTable("BonConsum");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataBonConsum).HasColumnType("datetime");
            entity.Property(e => e.DataCreareDocument).HasColumnType("datetime");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarBonConsum)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieBonConsum)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
        });

        modelBuilder.Entity<BonConsumProduse>(entity =>
        {
            entity.ToTable("BonConsumProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContContabil)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DenumireProdus)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Grupa)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IdbonConsum).HasColumnName("IDBonConsum");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdprodusReceptie).HasColumnName("IDProdusReceptie");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");

            entity.HasOne(d => d.IdbonConsumNavigation).WithMany(p => p.BonConsumProduses)
                .HasForeignKey(d => d.IdbonConsum)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BonConsumProduse_BonConsum");
        });

        modelBuilder.Entity<CarduriFidelizare>(entity =>
        {
            entity.ToTable("CarduriFidelizare");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresa)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Cnp)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("EMail");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdgrupaFidelizare).HasColumnName("IDGrupaFidelizare");
            entity.Property(e => e.NumarCard)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Nume)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Prenume)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Telefon)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.CarduriFidelizares)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CarduriFidelizare_NomenclatorGestiuni");
        });

        modelBuilder.Entity<CaseBanci>(entity =>
        {
            entity.ToTable("CaseBanci");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Banca)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Cont)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Iban)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("IBAN");
            entity.Property(e => e.SimbolBanca)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Valuta)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<CaseMarcatGestiune>(entity =>
        {
            entity.ToTable("CaseMarcatGestiune");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CasaMarcat)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodCasaFaraTva).HasColumnName("CodCasaFaraTVA");
            entity.Property(e => e.Descriere)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DirectorRaspuns).HasMaxLength(250);
            entity.Property(e => e.DirectorRetea)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Locatie)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarCasa)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Port)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.CaseMarcatGestiunes)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CaseMarcatGestiune_NomenclatorGestiuni");
        });

        modelBuilder.Entity<Delegati>(entity =>
        {
            entity.ToTable("Delegati");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Auto)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarCi)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("NumarCI");
            entity.Property(e => e.NumePrenume)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SeriaCi)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("SeriaCI");
        });

        modelBuilder.Entity<DeliveryAgenti>(entity =>
        {
            entity.ToTable("DeliveryAgenti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Agent)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Masina)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<DeliveryClienti>(entity =>
        {
            entity.ToTable("DeliveryClienti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Nume)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TelefonClientSpalare)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<DeliveryClientiAdrese>(entity =>
        {
            entity.ToTable("DeliveryClientiAdrese");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apartament)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Etaj)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IdclientDelivery).HasColumnName("IDClientDelivery");
            entity.Property(e => e.Judet)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Localitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Numar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Scara)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Strada)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdclientDeliveryNavigation).WithMany(p => p.DeliveryClientiAdreses)
                .HasForeignKey(d => d.IdclientDelivery)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DeliveryClientiAdrese_DeliveryClienti");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.ToTable("Factura");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ClientHotel)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CnpclientHotel)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CNPClientHotel");
            entity.Property(e => e.CotaTva).HasColumnName("CotaTVA");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataScadenta).HasColumnType("datetime");
            entity.Property(e => e.HotelClientAdresa).HasMaxLength(1000);
            entity.Property(e => e.HotelClientJudet).HasMaxLength(250);
            entity.Property(e => e.HotelClientLocalitate).HasMaxLength(250);
            entity.Property(e => e.IdcontractSpalatorie).HasColumnName("IDContractSpalatorie");
            entity.Property(e => e.Iddelegat).HasColumnName("IDDelegat");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idpartener).HasColumnName("IDPartener");
            entity.Property(e => e.Idsubcontractant).HasColumnName("IDSubcontractant");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Numar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarAvizInsotireMarfa)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumeUtilizatorFactura).HasMaxLength(250);
            entity.Property(e => e.Observatii)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.Seria)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipFactura)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipPreluare)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<FacturaProduse>(entity =>
        {
            entity.ToTable("FacturaProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Grupa)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GrupaTva)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("GrupaTVA");
            entity.Property(e => e.Idfactura).HasColumnName("IDFactura");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdnotaPlata).HasColumnName("IDNotaPlata");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.NumarComanda)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PretUnitarFaraTva).HasColumnName("PretUnitarFaraTVA");
            entity.Property(e => e.ProdusText)
                .HasMaxLength(80)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");
            entity.Property(e => e.ValoareFaraTva).HasColumnName("ValoareFaraTVA");
            entity.Property(e => e.ValoareTva).HasColumnName("ValoareTVA");

            entity.HasOne(d => d.IdfacturaNavigation).WithMany(p => p.FacturaProduses)
                .HasForeignKey(d => d.Idfactura)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FacturaProduse_Factura");
        });

        modelBuilder.Entity<FidelizareGrupe>(entity =>
        {
            entity.ToTable("FidelizareGrupe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.FidelizareGrupes)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FidelizareGrupe_NomenclatorGestiuni");
        });

        modelBuilder.Entity<FidelizareProduse>(entity =>
        {
            entity.ToTable("FidelizareProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdfidelizareGrupe).HasColumnName("IDFidelizareGrupe");
            entity.Property(e => e.TipDiscount)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdfidelizareGrupeNavigation).WithMany(p => p.FidelizareProduses)
                .HasForeignKey(d => d.IdfidelizareGrupe)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FidelizareProduse_FidelizareGrupe");
        });

        modelBuilder.Entity<GestiuniActualizare>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GestiuniActualizare");

            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<HotelConfigurareScheduler>(entity =>
        {
            entity.ToTable("HotelConfigurareScheduler");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CuloareCheckIn)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CuloareCheckIN");
            entity.Property(e => e.CuloareCheckOut)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CuloareRezervare)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IdprodusServiciuCazare).HasColumnName("IDProdusServiciuCazare");
            entity.Property(e => e.OraPredareCamera).HasColumnType("datetime");
        });

        modelBuilder.Entity<IesiriReceptie>(entity =>
        {
            entity.ToTable("IesiriReceptie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnType("date");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdgestiuneDestinatie).HasColumnName("IDGestiuneDestinatie");
            entity.Property(e => e.Idiesire).HasColumnName("IDIesire");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdprodusReceptie).HasColumnName("IDProdusReceptie");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipIesire)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");

            entity.HasOne(d => d.IdprodusReceptieNavigation).WithMany(p => p.IesiriRecepties)
                .HasForeignKey(d => d.IdprodusReceptie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_IesiriReceptie_ProduseReceptie");
        });

        modelBuilder.Entity<InchidereZi>(entity =>
        {
            entity.ToTable("InchidereZi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataZiInchisa).HasColumnType("date");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Iduser).HasColumnName("IDuser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<InchidereZiDt>(entity =>
        {
            entity.ToTable("InchidereZiDTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiuneStocuri)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataDts)
                .HasColumnType("datetime")
                .HasColumnName("DataDTS");
            entity.Property(e => e.IdgestiuneDepozit).HasColumnName("IDGestiuneDepozit");
            entity.Property(e => e.IdgestiuneProductie).HasColumnName("IDGestiuneProductie");
            entity.Property(e => e.Info)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarDts).HasColumnName("NumarDTS");
        });

        modelBuilder.Entity<InchidereZiproduseDt>(entity =>
        {
            entity.ToTable("InchidereZIProduseDTS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CantitateDts).HasColumnName("CantitateDTS");
            entity.Property(e => e.IdinchidereZiDts).HasColumnName("IDInchidereZiDTS");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");

            entity.HasOne(d => d.IdinchidereZiDtsNavigation).WithMany(p => p.InchidereZiproduseDts)
                .HasForeignKey(d => d.IdinchidereZiDts)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InchidereZIProduseDTS_InchidereZiDTS1");
        });

        modelBuilder.Entity<InfoMesaje>(entity =>
        {
            entity.ToTable("InfoMesaje");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Info)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Text)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
        });

        modelBuilder.Entity<Inventar>(entity =>
        {
            entity.ToTable("Inventar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataSalvareInventar).HasColumnType("datetime");
            entity.Property(e => e.FaraFormaPlata)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Gestiunea)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.InchideriZi)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MeseNeinchise)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.StocLaData).HasColumnType("datetime");
            entity.Property(e => e.Utilizator)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<InventarProduse>(entity =>
        {
            entity.ToTable("InventarProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DenumireProdus)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idinventar).HasColumnName("IDInventar");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");

            entity.HasOne(d => d.IdinventarNavigation).WithMany(p => p.InventarProduses)
                .HasForeignKey(d => d.Idinventar)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InventarProduse_Inventar");
        });

        modelBuilder.Entity<LayoutGrid>(entity =>
        {
            entity.ToTable("LayoutGrid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.Layout)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.NumeRaport)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipRaport)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IduserNavigation).WithMany(p => p.LayoutGrids)
                .HasForeignKey(d => d.Iduser)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_LayoutGrid_Utilizatori");
        });

        modelBuilder.Entity<ListaSali>(entity =>
        {
            entity.ToTable("ListaSali");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CotaTvacurenta).HasColumnName("CotaTVACurenta");
            entity.Property(e => e.CotaTvavanzare).HasColumnName("CotaTVAVanzare");
            entity.Property(e => e.CuloareSala)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DenumireSala)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.ModificaTvavanzare).HasColumnName("ModificaTVAVanzare");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipVanzare)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.ListaSalis)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ListaSali_NomenclatorGestiuni");
        });

        modelBuilder.Entity<Locatii>(entity =>
        {
            entity.ToTable("Locatii");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idaranjare).HasColumnName("IDAranjare");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdmeseScaune).HasColumnName("IDMeseScaune");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.IdsalaAranjare).HasColumnName("IDSalaAranjare");

            entity.HasOne(d => d.IdmeseScauneNavigation).WithMany(p => p.Locatiis)
                .HasForeignKey(d => d.IdmeseScaune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Locatii_MeseScaune1");
        });

        modelBuilder.Entity<LogoHotel>(entity =>
        {
            entity.ToTable("LogoHotel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientHotel)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataOperatiune).HasColumnType("datetime");
            entity.Property(e => e.Detaliu)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idrezervare).HasColumnName("IDRezervare");
            entity.Property(e => e.IdrezervareCopil).HasColumnName("IDRezervareCopil");
            entity.Property(e => e.Operatiune)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Utilizator)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Mentiuni>(entity =>
        {
            entity.ToTable("Mentiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<MeseScaune>(entity =>
        {
            entity.ToTable("MeseScaune");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcopil).HasColumnName("IDcopil");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdnotaPlataCreata).HasColumnName("IDNotaPlataCreata");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.Machinename)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MACHINENAME");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.StatusCamera)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ToolTip)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdsalaNavigation).WithMany(p => p.MeseScaunes)
                .HasForeignKey(d => d.Idsala)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MeseScaune_ListaSali");
        });

        modelBuilder.Entity<NomenclatorAlteFormaPlatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IdplataCasaMarcat).HasColumnName("IDPlataCasaMarcat");
            entity.Property(e => e.Posbancar).HasColumnName("POSBancar");
        });

        modelBuilder.Entity<NomenclatorCategoriiContabile>(entity =>
        {
            entity.ToTable("NomenclatorCategoriiContabile");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cont)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorGestiuni>(entity =>
        {
            entity.ToTable("NomenclatorGestiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ComisiaReceptieNume1)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ComisiaReceptieNume2)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CuAdaos)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataErr)
                .HasColumnType("datetime")
                .HasColumnName("DataERR");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IdgestiuneDts).HasColumnName("IDGestiuneDTS");
            entity.Property(e => e.IdgestiuneHotelAtasata).HasColumnName("IDGestiuneHotelAtasata");
            entity.Property(e => e.IdinregistrareErr).HasColumnName("IDInregistrareERR");
            entity.Property(e => e.IdinregistrareTransferErr).HasColumnName("IDInregistrareTransferERR");
            entity.Property(e => e.IduserBlocat).HasColumnName("IDUserBlocat");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Mentiuni)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.NotaPlataAdresa)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NotaPlataDenumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NotaPlataMesaj1)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NotaPlataMesaj2)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NotaPlataRestaurant)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PretulContineTva)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("PretulContineTVA");
            entity.Property(e => e.PrimitInGestiuneNume)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieBonConsum)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieFactura)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieReceptie)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieTransfer)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipOperatiuneErr)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TipOperatiuneERR");
        });

        modelBuilder.Entity<NomenclatorGrupa>(entity =>
        {
            entity.ToTable("NomenclatorGrupa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorHappyHour>(entity =>
        {
            entity.ToTable("NomenclatorHappyHour");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.OraInceput).HasColumnType("datetime");
            entity.Property(e => e.OraSfarsit).HasColumnType("datetime");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.NomenclatorHappyHours)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NomenclatorHappyHour_NomenclatorGestiuni");
        });

        modelBuilder.Entity<NomenclatorJudete>(entity =>
        {
            entity.ToTable("NomenclatorJudete");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorLocatie>(entity =>
        {
            entity.ToTable("NomenclatorLocatie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorParteneri>(entity =>
        {
            entity.ToTable("NomenclatorParteneri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresa)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.AnulInfintarii)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Banca)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodCaen)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodFiscal)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodPostal)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Cont)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Denumire)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Informatii)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Judet)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Localitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarRegComert)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tara)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipulDeActivitate)
                .HasMaxLength(550)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorProduseHappyHour>(entity =>
        {
            entity.ToTable("NomenclatorProduseHappyHour");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnomenclatorHappyHour).HasColumnName("IDNomenclatorHappyHour");
            entity.Property(e => e.TipDiscount)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdnomenclatorHappyHourNavigation).WithMany(p => p.NomenclatorProduseHappyHours)
                .HasForeignKey(d => d.IdnomenclatorHappyHour)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NomenclatorProduseHappyHour_NomenclatorHappyHour");
        });

        modelBuilder.Entity<NomenclatorSetariDiscount>(entity =>
        {
            entity.ToTable("NomenclatorSetariDiscount");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.ParolaDiscount)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipDiscount)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.NomenclatorSetariDiscounts)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NomenclatorSetariDiscount_NomenclatorGestiuni");
        });

        modelBuilder.Entity<NomenclatorSocietate>(entity =>
        {
            entity.ToTable("NomenclatorSocietate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresa)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Banca)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Banca2)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodFiscal)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Comisia)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ContBancar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ContBancar2)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Contabilitate)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CotaTva).HasColumnName("CotaTVA");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Gestionar)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Judet)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Localitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Mobil)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OraInceput).HasColumnType("datetime");
            entity.Property(e => e.PlatitoareTva).HasColumnName("PlatitoareTVA");
            entity.Property(e => e.PunctDeLucru)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.RegComert)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tara)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TextAntecalculatie)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TextFactura)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.TipIncasareTva)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text")
                .HasColumnName("TipIncasareTVA");
            entity.Property(e => e.Versiune)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Web)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorTari>(entity =>
        {
            entity.ToTable("NomenclatorTari");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NomenclatorTva>(entity =>
        {
            entity.ToTable("NomenclatorTVA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GrupaTva)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("GrupaTVA");
        });

        modelBuilder.Entity<NomenclatorUm>(entity =>
        {
            entity.ToTable("NomenclatorUM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<NotaDePlataFisierCasaMarcat>(entity =>
        {
            entity.ToTable("NotaDePlataFisierCasaMarcat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataCreareFisier).HasColumnType("datetime");
            entity.Property(e => e.IdnotaPlata).HasColumnName("IDNotaPlata");
            entity.Property(e => e.MachineName)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumeFisier)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TextFisier)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.Utilizator)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdnotaPlataNavigation).WithMany(p => p.NotaDePlataFisierCasaMarcats)
                .HasForeignKey(d => d.IdnotaPlata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NotaDePlataFisierCasaMarcat_NotaDePlata");
        });

        modelBuilder.Entity<NotaDePlatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NotaDePlata_1");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CasaMarcatId).HasColumnName("CasaMarcatID");
            entity.Property(e => e.CifClient)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ClientHotel)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DataGenerarePlata).HasColumnType("datetime");
            entity.Property(e => e.Dts).HasColumnName("DTS");
            entity.Property(e => e.Faza)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FisaTratament).HasMaxLength(250);
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.IdclientFidelizare).HasColumnName("IDClientFidelizare");
            entity.Property(e => e.IdcontractSpalatorie).HasColumnName("IDContractSpalatorie");
            entity.Property(e => e.Idfactura).HasColumnName("IDFactura");
            entity.Property(e => e.IdformaPlata).HasColumnName("IDFormaPlata");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idmasa).HasColumnName("IDMasa");
            entity.Property(e => e.Idprotocol).HasColumnName("IDProtocol");
            entity.Property(e => e.IdrezervareHotel).HasColumnName("IDRezervareHotel");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.LocalMachine)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarComanda)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SeTrimiteErp).HasColumnName("SeTrimiteERP");
            entity.Property(e => e.StareCasaMarcat)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipNotaPlata)
                .HasMaxLength(25)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipVanzare)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TratamentData).HasColumnType("datetime");
            entity.Property(e => e.TratamentNume).HasMaxLength(250);
            entity.Property(e => e.TratamentObservatii).HasMaxLength(1000);
            entity.Property(e => e.TrimisErp).HasColumnName("TrimisERP");
        });

        modelBuilder.Entity<NotaPlataInformatiiLivrare>(entity =>
        {
            entity.ToTable("NotaPlataInformatiiLivrare");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apartament)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Etaj)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.IdcontractSpalatorie).HasColumnName("IDContractSpalatorie");
            entity.Property(e => e.IdnotaPlata).HasColumnName("IDNotaPlata");
            entity.Property(e => e.IdnumarInmatriculare).HasColumnName("IDNumarInmatriculare");
            entity.Property(e => e.Judet)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Localitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Numar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Scara)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Strada)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdnotaPlataNavigation).WithMany(p => p.NotaPlataInformatiiLivrares)
                .HasForeignKey(d => d.IdnotaPlata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NotaPlataInformatiiLivrare_NotaDePlata");
        });

        modelBuilder.Entity<NotaPlataMentiuni>(entity =>
        {
            entity.ToTable("NotaPlataMentiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdprodusNotaPlata).HasColumnName("IDProdusNotaPlata");
            entity.Property(e => e.Mentiune)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdprodusNotaPlataNavigation).WithMany(p => p.NotaPlataMentiunis)
                .HasForeignKey(d => d.IdprodusNotaPlata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NotaPlataMentiuni_NotaPlataProduse");
        });

        modelBuilder.Entity<NotaPlataProduse>(entity =>
        {
            entity.ToTable("NotaPlataProduse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DataComandaProdus).HasColumnType("date");
            entity.Property(e => e.DataGenerarePlata).HasColumnType("datetime");
            entity.Property(e => e.DataTimpComandaProdus).HasColumnType("datetime");
            entity.Property(e => e.DateTimeClientPleaca).HasColumnType("datetime");
            entity.Property(e => e.GrupaTva)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("GrupaTVA");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdinchidereZi).HasColumnName("IDInchidereZi");
            entity.Property(e => e.Idmasa).HasColumnName("IDMasa");
            entity.Property(e => e.IdnotaPlata).HasColumnName("IDNotaPlata");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.IduserProdus).HasColumnName("IDUserProdus");
            entity.Property(e => e.NumarComanda)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");

            entity.HasOne(d => d.IdnotaPlataNavigation).WithMany(p => p.NotaPlataProduses)
                .HasForeignKey(d => d.IdnotaPlata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NotaPlataProduse_NotaDePlata");
        });

        modelBuilder.Entity<NotaPlataProduseStornate>(entity =>
        {
            entity.ToTable("NotaPlataProduseStornate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataComandaProdus).HasColumnType("datetime");
            entity.Property(e => e.IdnotaPlata).HasColumnName("IDNotaPlata");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IduserProdus).HasColumnName("IDUserProdus");

            entity.HasOne(d => d.IdnotaPlataNavigation).WithMany(p => p.NotaPlataProduseStornates)
                .HasForeignKey(d => d.IdnotaPlata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NotaPlataProduseStornate_NotaDePlata");
        });

        modelBuilder.Entity<NotaPlataRetetar>(entity =>
        {
            entity.ToTable("NotaPlataRetetar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataComandaProdus).HasColumnType("date");
            entity.Property(e => e.GrupaTva)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("GrupaTVA");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idmasa).HasColumnName("IDMasa");
            entity.Property(e => e.Idmaterial).HasColumnName("IDMaterial");
            entity.Property(e => e.IdprodusFinit).HasColumnName("IDProdusFinit");
            entity.Property(e => e.IdprodusNotaPlata).HasColumnName("IDProdusNotaPlata");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.NumarComanda)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");

            entity.HasOne(d => d.IdprodusNotaPlataNavigation).WithMany(p => p.NotaPlataRetetars)
                .HasForeignKey(d => d.IdprodusNotaPlata)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_NotaPlataRetetar_NotaPlataProduse");
        });

        modelBuilder.Entity<PimPosHash>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PimPosHash");

            entity.Property(e => e.Denumire)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Hash)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<PretProdusGestiune>(entity =>
        {
            entity.ToTable("PretProdusGestiune");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgensiune).HasColumnName("IDGensiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");

            entity.HasOne(d => d.IdgensiuneNavigation).WithMany(p => p.PretProdusGestiunes)
                .HasForeignKey(d => d.Idgensiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PretProdusGestiune_NomenclatorGestiuni");

            entity.HasOne(d => d.IdprodusNavigation).WithMany(p => p.PretProdusGestiunes)
                .HasForeignKey(d => d.Idprodus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PretProdusGestiune_Produse");
        });

        modelBuilder.Entity<ProdusCantitatiPredefinite>(entity =>
        {
            entity.ToTable("ProdusCantitatiPredefinite");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Alias)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");

            entity.HasOne(d => d.IdprodusNavigation).WithMany(p => p.ProdusCantitatiPredefinites)
                .HasForeignKey(d => d.Idprodus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProdusCantitatiPredefinite_Produse");
        });

        modelBuilder.Entity<ProdusDescriere>(entity =>
        {
            entity.ToTable("ProdusDescriere");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descriere)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");

            entity.HasOne(d => d.IdprodusNavigation).WithMany(p => p.ProdusDescrieres)
                .HasForeignKey(d => d.Idprodus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProdusDescriere_Produse");
        });

        modelBuilder.Entity<ProdusRetete>(entity =>
        {
            entity.ToTable("ProdusRetete");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idmaterial).HasColumnName("IDMaterial");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Idum).HasColumnName("IDUM");
            entity.Property(e => e.Mod)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdprodusNavigation).WithMany(p => p.ProdusRetetes)
                .HasForeignKey(d => d.Idprodus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProdusRetete_Produse");
        });

        modelBuilder.Entity<Produse>(entity =>
        {
            entity.ToTable("Produse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Categorie)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Cod)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ListaGestiuni)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Stare)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipReteta)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um).HasColumnName("UM");
        });

        modelBuilder.Entity<ProduseCoduriBare>(entity =>
        {
            entity.ToTable("ProduseCoduriBare");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodaBare)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");

            entity.HasOne(d => d.IdprodusNavigation).WithMany(p => p.ProduseCoduriBares)
                .HasForeignKey(d => d.Idprodus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProduseCoduriBare_Produse");
        });

        modelBuilder.Entity<ProduseInventarPeCamera>(entity =>
        {
            entity.ToTable("ProduseInventarPeCamera");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");

            entity.HasOne(d => d.IdscaunNavigation).WithMany(p => p.ProduseInventarPeCameras)
                .HasForeignKey(d => d.Idscaun)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProduseInventarPeCamera_MeseScaune");
        });

        modelBuilder.Entity<ProduseMiniBarPeCamera>(entity =>
        {
            entity.ToTable("ProduseMiniBarPeCamera");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");

            entity.HasOne(d => d.IdscaunNavigation).WithMany(p => p.ProduseMiniBarPeCameras)
                .HasForeignKey(d => d.Idscaun)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProduseMiniBarPeCamera_MeseScaune");
        });

        modelBuilder.Entity<ProdusePeMasa>(entity =>
        {
            entity.ToTable("ProdusePeMasa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataComandaProdus).HasColumnType("datetime");
            entity.Property(e => e.GrupaTva)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("GrupaTVA");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idmasa).HasColumnName("IDMasa");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdrezervareCamera).HasColumnName("IDRezervareCamera");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.IduserProdus).HasColumnName("IDUserProdus");
            entity.Property(e => e.Locatie)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarComanda)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumeMasa)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumeScaun)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumeUser)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProdusText)
                .HasMaxLength(80)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipReteta)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um)
                .HasMaxLength(30)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");
        });

        modelBuilder.Entity<ProdusePeMasaMnetiuni>(entity =>
        {
            entity.ToTable("produsePeMasaMnetiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Mentiune)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdprodusNavigation).WithMany(p => p.ProdusePeMasaMnetiunis)
                .HasForeignKey(d => d.Idprodus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_produsePeMasaMnetiuni_ProdusePeMasa");
        });

        modelBuilder.Entity<ProduseReceptie>(entity =>
        {
            entity.ToTable("ProduseReceptie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContContabil)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataReceptie).HasColumnType("datetime");
            entity.Property(e => e.Grupa)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdprodusTransfer).HasColumnName("IDProdusTransfer");
            entity.Property(e => e.Idreceptie).HasColumnName("IDReceptie");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Tvainitial).HasColumnName("TVAInitial");
            entity.Property(e => e.Tvaneexigibil).HasColumnName("TVANeexigibil");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ValoareTvaachizitie).HasColumnName("ValoareTVAAchizitie");

            entity.HasOne(d => d.IdreceptieNavigation).WithMany(p => p.ProduseRecepties)
                .HasForeignKey(d => d.Idreceptie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProduseReceptie_Receptii");
        });

        modelBuilder.Entity<ProduseReceptieSchimbarePret>(entity =>
        {
            entity.ToTable("ProduseReceptieSchimbarePret");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdprodusReceptie).HasColumnName("IDProdusReceptie");

            entity.HasOne(d => d.IdprodusReceptieNavigation).WithMany(p => p.ProduseReceptieSchimbarePrets)
                .HasForeignKey(d => d.IdprodusReceptie)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ProduseReceptieSchimbarePret_ProduseReceptie");
        });

        modelBuilder.Entity<ProduseVanzareDirectum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdcodBare).HasColumnName("IDCodBare");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Protocol>(entity =>
        {
            entity.ToTable("Protocol");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ReceptiePlati>(entity =>
        {
            entity.ToTable("ReceptiePlati");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DataDocument).HasColumnType("datetime");
            entity.Property(e => e.IdcasaBanca).HasColumnName("IDCasaBanca");
            entity.Property(e => e.Idfurnizor).HasColumnName("IDFurnizor");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Observatii)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Serie)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Utilizator)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ReceptiePlatiAchitari>(entity =>
        {
            entity.ToTable("ReceptiePlatiAchitari");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataReceptie).HasColumnType("datetime");
            entity.Property(e => e.Idreceptie).HasColumnName("IDReceptie");
            entity.Property(e => e.IdreceptiePlati).HasColumnName("IDReceptiePlati");
            entity.Property(e => e.TipDocumentCorespondent)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdreceptiePlatiNavigation).WithMany(p => p.ReceptiePlatiAchitaris)
                .HasForeignKey(d => d.IdreceptiePlati)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReceptiePlatiAchitari_ReceptiePlati");
        });

        modelBuilder.Entity<Receptii>(entity =>
        {
            entity.ToTable("Receptii");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContDocumentCorespondent)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataCreareDocument).HasColumnType("datetime");
            entity.Property(e => e.DataDocument).HasColumnType("datetime");
            entity.Property(e => e.DataDocumentCorespondent).HasColumnType("datetime");
            entity.Property(e => e.DataModificareReceptie)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Iddelegat).HasColumnName("IDDelegat");
            entity.Property(e => e.Idfurnizor).HasColumnName("IDFurnizor");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdgestiuneTransfer).HasColumnName("IDGestiuneTransfer");
            entity.Property(e => e.Idpartener).HasColumnName("IDPartener");
            entity.Property(e => e.Idtransfer).HasColumnName("IDTransfer");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarDocument)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarDocumentCorespondent)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.RegimTva)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("RegimTVA");
            entity.Property(e => e.SerieDocument)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieDocumentCorespondent)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipDocument)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipDocumentCorespondent)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.Receptiis)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Receptii_NomenclatorGestiuni");
        });

        modelBuilder.Entity<RezervariCamere>(entity =>
        {
            entity.ToTable("RezervariCamere");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ActIdentitate)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Adresa)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Agentie).HasMaxLength(250);
            entity.Property(e => e.BeneficiarActIdentitate).HasMaxLength(250);
            entity.Property(e => e.BeneficiarActIdentitateCnp)
                .HasMaxLength(250)
                .HasColumnName("BeneficiarActIdentitateCNP");
            entity.Property(e => e.BeneficiarActIdentitateEliberatDe).HasMaxLength(500);
            entity.Property(e => e.BeneficiarActIdentitateNumar).HasMaxLength(250);
            entity.Property(e => e.BeneficiarActIdentitateSeria).HasMaxLength(250);
            entity.Property(e => e.BeneficiarAdresa).HasMaxLength(1000);
            entity.Property(e => e.BeneficiarJudet).HasMaxLength(250);
            entity.Property(e => e.BeneficiarNume).HasMaxLength(250);
            entity.Property(e => e.BeneficiarOras).HasMaxLength(250);
            entity.Property(e => e.BeneficiarTara).HasMaxLength(250);
            entity.Property(e => e.Cnp)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CNP");
            entity.Property(e => e.CodZip)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CreatDe)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.DataNasterii).HasColumnType("datetime");
            entity.Property(e => e.DataPrezenta).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.EndTimeScheduler).HasColumnType("datetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FisaTratament).HasMaxLength(250);
            entity.Property(e => e.IdentitateEleibaratDe)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idfactura).HasColumnName("IDFactura");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdnotaPlata).HasColumnName("IDNotaPlata");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Idtip).HasColumnName("IDTip");
            entity.Property(e => e.Judet)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LoculNasterii)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MachineName)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ModificatDe)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Nationalitatea)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarBilet).HasMaxLength(250);
            entity.Property(e => e.NumarIdentitate)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Nume)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ObservatiiCheckIn)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ObservatiiCheckIN");
            entity.Property(e => e.ObservatiiCheckOut)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ObservatiiCheckOUT");
            entity.Property(e => e.Oras)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SeriaIdentitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieBilet).HasMaxLength(250);
            entity.Property(e => e.SerieCartela).HasMaxLength(250);
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.StartTimeScheduler).HasColumnType("datetime");
            entity.Property(e => e.Tara)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TelefonFix)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TelefonMobil)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Voucher).HasMaxLength(250);
            entity.Property(e => e.Web)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<RezervariCamereClienti>(entity =>
        {
            entity.ToTable("RezervariCamereClienti");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Idrezervare).HasColumnName("IDRezervare");
            entity.Property(e => e.NumarActIdentitate)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Nume)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TipActIdentitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdrezervareNavigation).WithMany(p => p.RezervariCamereClientis)
                .HasForeignKey(d => d.Idrezervare)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RezervariCamereClienti_RezervariCamere");
        });

        modelBuilder.Entity<RezervariCamereTip>(entity =>
        {
            entity.ToTable("RezervariCamereTip");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
        });

        modelBuilder.Entity<RezervariCamereTipProduse>(entity =>
        {
            entity.ToTable("RezervariCamereTipProduse");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdrezervareCamereTip).HasColumnName("IDRezervareCamereTip");

            entity.HasOne(d => d.IdrezervareCamereTipNavigation).WithMany(p => p.RezervariCamereTipProduses)
                .HasForeignKey(d => d.IdrezervareCamereTip)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RezervariCamereTipProduse_RezervariCamereTip");
        });

        modelBuilder.Entity<RezervariMese>(entity =>
        {
            entity.ToTable("RezervariMese");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idmasa).HasColumnName("IDMasa");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.IntervalInceput).HasColumnType("datetime");
            entity.Property(e => e.IntervalSfarsit).HasColumnType("datetime");
            entity.Property(e => e.NumeClient)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Telefon)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<ScaunClientDeliveryAlte>(entity =>
        {
            entity.ToTable("ScaunClientDeliveryAlte");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apartament)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Etaj)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idadresa).HasColumnName("IDAdresa");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.IdcontractSpalatorie).HasColumnName("IDContractSpalatorie");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Judet)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Localitate)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Numar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Scara)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Strada)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdscaunNavigation).WithMany(p => p.ScaunClientDeliveryAltes)
                .HasForeignKey(d => d.Idscaun)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ScaunClientDeliveryAlte_MeseScaune");
        });

        modelBuilder.Entity<SchimbarePret>(entity =>
        {
            entity.ToTable("SchimbarePret");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Observatii)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<SchimbarePretProduse>(entity =>
        {
            entity.ToTable("SchimbarePretProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdschimbarePret).HasColumnName("IDSchimbarePret");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Tvanou).HasColumnName("TVANou");

            entity.HasOne(d => d.IdschimbarePretNavigation).WithMany(p => p.SchimbarePretProduses)
                .HasForeignKey(d => d.IdschimbarePret)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SchimbarePretProduse_SchimbarePret");
        });

        modelBuilder.Entity<SesiuniSm>(entity =>
        {
            entity.ToTable("SesiuniSMS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Subiect)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TemplateSms)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text")
                .HasColumnName("TemplateSMS");
        });

        modelBuilder.Entity<SesiuniSmsinfo>(entity =>
        {
            entity.ToTable("SesiuniSMSInfo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idclient)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("IDClient");
            entity.Property(e => e.Idsesiune).HasColumnName("IDSesiune");

            entity.HasOne(d => d.IdsesiuneNavigation).WithMany(p => p.SesiuniSmsinfos)
                .HasForeignKey(d => d.Idsesiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SesiuniSMSInfo_SesiuniSMS");
        });

        modelBuilder.Entity<SetariImprimantaLocatie>(entity =>
        {
            entity.ToTable("SetariImprimantaLocatie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idlocatie).HasColumnName("IDLocatie");
            entity.Property(e => e.Imprimanta)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.SetariImprimantaLocaties)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SetariImprimantaLocatie_NomenclatorGestiuni");
        });

        modelBuilder.Entity<SetariImprimantaRapoarte>(entity =>
        {
            entity.ToTable("SetariImprimantaRapoarte");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Imprimanta)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.SetariImprimantaRapoartes)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SetariImprimantaRapoarte_NomenclatorGestiuni");
        });

        modelBuilder.Entity<SpalatorieAutovehicule>(entity =>
        {
            entity.ToTable("SpalatorieAutovehicule");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdspalatorieContract).HasColumnName("IDSpalatorieContract");
            entity.Property(e => e.IdtipAutovehicul).HasColumnName("IDTipAutovehicul");
            entity.Property(e => e.Marca)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarInmatriculare)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdspalatorieContractNavigation).WithMany(p => p.SpalatorieAutovehicules)
                .HasForeignKey(d => d.IdspalatorieContract)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SpalatorieAutovehicule_SpalatorieContract1");
        });

        modelBuilder.Entity<SpalatorieContract>(entity =>
        {
            entity.ToTable("SpalatorieContract");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DataFacturare).HasColumnType("datetime");
            entity.Property(e => e.DataFinalizareContract).HasColumnType("date");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idsubcontractant).HasColumnName("IDSubcontractant");
            entity.Property(e => e.NumarContract)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TextFactura)
                .HasMaxLength(1500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<SpalatorieDelegat>(entity =>
        {
            entity.ToTable("SpalatorieDelegat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresa)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.IdspalatorieContract).HasColumnName("IDSpalatorieContract");
            entity.Property(e => e.NumeSiPrenume)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Telefon)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdspalatorieContractNavigation).WithMany(p => p.SpalatorieDelegats)
                .HasForeignKey(d => d.IdspalatorieContract)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SpalatorieDelegat_SpalatorieContract1");
        });

        modelBuilder.Entity<SpalatoriePretContract>(entity =>
        {
            entity.ToTable("SpalatoriePretContract");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdspalatorieContract).HasColumnName("IDSpalatorieContract");

            entity.HasOne(d => d.IdspalatorieContractNavigation).WithMany(p => p.SpalatoriePretContracts)
                .HasForeignKey(d => d.IdspalatorieContract)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SpalatoriePretContract_SpalatorieContract");
        });

        modelBuilder.Entity<SpalatorieTipAutovehicul>(entity =>
        {
            entity.ToTable("SpalatorieTipAutovehicul");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TipAutovehicul)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<StareSm>(entity =>
        {
            entity.ToTable("StareSMS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataTrimitereSms)
                .HasColumnType("datetime")
                .HasColumnName("DataTrimitereSMS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Info)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.MachineName)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MesajSms)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MesajSMS");
            entity.Property(e => e.NumeClient)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TelefonClient)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TrimisDe)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<StariAtasateCamera>(entity =>
        {
            entity.ToTable("StariAtasateCamera");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idscaun).HasColumnName("IDScaun");
            entity.Property(e => e.Idstare).HasColumnName("IDStare");

            entity.HasOne(d => d.IdscaunNavigation).WithMany(p => p.StariAtasateCameras)
                .HasForeignKey(d => d.Idscaun)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StariAtasateCamera_MeseScaune1");
        });

        modelBuilder.Entity<StatusCamera>(entity =>
        {
            entity.ToTable("StatusCamera");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<TemplateSm>(entity =>
        {
            entity.ToTable("TemplateSMS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.TextSmsfinalizareComanda)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TextSMSFinalizareComanda");
            entity.Property(e => e.TextSmslivrareComanda)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TextSMSLivrareComanda");
            entity.Property(e => e.TextSmsprimireComanda)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("TextSMSPrimireComanda");
        });

        modelBuilder.Entity<TipAranjareGestiune>(entity =>
        {
            entity.ToTable("TipAranjareGestiune");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Denumire)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");

            entity.HasOne(d => d.IdgestiuneNavigation).WithMany(p => p.TipAranjareGestiunes)
                .HasForeignKey(d => d.Idgestiune)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TipAranjareGestiune_NomenclatorGestiuni");
        });

        modelBuilder.Entity<TransArtConnector>(entity =>
        {
            entity.ToTable("TransArtConnector");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Firma)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.IpwebService)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("IPWebService");
            entity.Property(e => e.Parola)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProdusHhfidelizare)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ProdusHHFidelizare");
            entity.Property(e => e.Sursa).HasMaxLength(250);
            entity.Property(e => e.TertInfoAprovizionare)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TimpExport).HasColumnType("datetime");
            entity.Property(e => e.TimpImport).HasColumnType("datetime");
            entity.Property(e => e.Utilizator)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.VersiuneWebServive)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<TransArtConnectorGestiuni>(entity =>
        {
            entity.ToTable("TransArtConnectorGestiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NumeGestiune)
                .HasMaxLength(150)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<TransArtHash>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransArtHash");

            entity.Property(e => e.Denumire)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Hash)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnType("text");
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.ToTable("Transfer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataCreareDocument).HasColumnType("datetime");
            entity.Property(e => e.DataTransfer).HasColumnType("datetime");
            entity.Property(e => e.IdgestiuneaDestinatie).HasColumnName("IDGestiuneaDestinatie");
            entity.Property(e => e.IdgestiuneaTransfer).HasColumnName("IDGestiuneaTransfer");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumarTranfer)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.SerieTransfer)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
        });

        modelBuilder.Entity<TransferProduse>(entity =>
        {
            entity.ToTable("TransferProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContContabil)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.DenumireProdus)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Grupa)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.IdprodusReceptie).HasColumnName("IDProdusReceptie");
            entity.Property(e => e.Idtransfer).HasColumnName("IDTransfer");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Observatii)
                .HasMaxLength(500)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Um)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("UM");

            entity.HasOne(d => d.IdtransferNavigation).WithMany(p => p.TransferProduses)
                .HasForeignKey(d => d.Idtransfer)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TransferProduse_Transfer");
        });

        modelBuilder.Entity<UtilizatorDrepturi>(entity =>
        {
            entity.ToTable("UtilizatorDrepturi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Drepturi)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Formular)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Sectiune)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdUtilizatorNavigation).WithMany(p => p.UtilizatorDrepturis)
                .HasForeignKey(d => d.IdUtilizator)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UtilizatorDrepturi_Utilizatori");
        });

        modelBuilder.Entity<Utilizatori>(entity =>
        {
            entity.ToTable("Utilizatori");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Card)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NumeUtilizator)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ParolaUtilizator)
                .HasMaxLength(250)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.TrimiteSms).HasColumnName("TrimiteSMS");
        });

        modelBuilder.Entity<UtilizatoriFormaPlatum>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdformaPlata).HasColumnName("IDFormaPlata");
            entity.Property(e => e.Idutilizator).HasColumnName("IDUtilizator");

            entity.HasOne(d => d.IdutilizatorNavigation).WithMany(p => p.UtilizatoriFormaPlata)
                .HasForeignKey(d => d.Idutilizator)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UtilizatoriFormaPlata_Utilizatori");
        });

        modelBuilder.Entity<UtilizatoriGestiuni>(entity =>
        {
            entity.ToTable("UtilizatoriGestiuni");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idutilizator).HasColumnName("IDUtilizator");

            entity.HasOne(d => d.IdutilizatorNavigation).WithMany(p => p.UtilizatoriGestiunis)
                .HasForeignKey(d => d.Idutilizator)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UtilizatoriGestiuni_Utilizatori");
        });

        modelBuilder.Entity<UtilizatoriMese>(entity =>
        {
            entity.ToTable("UtilizatoriMese");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Idmasa).HasColumnName("IDMasa");
            entity.Property(e => e.Idsala).HasColumnName("IDSala");
            entity.Property(e => e.Idutilizator).HasColumnName("IDUtilizator");

            entity.HasOne(d => d.IdutilizatorNavigation).WithMany(p => p.UtilizatoriMeses)
                .HasForeignKey(d => d.Idutilizator)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UtilizatoriMese_Utilizatori");
        });

        modelBuilder.Entity<VanzariDirecte>(entity =>
        {
            entity.ToTable("VanzariDirecte");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Data).HasColumnType("datetime");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idgestiune).HasColumnName("IDGestiune");
            entity.Property(e => e.Numar)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<VanzariDirecteProduse>(entity =>
        {
            entity.ToTable("VanzariDirecteProduse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdcodBare).HasColumnName("IDCodBare");
            entity.Property(e => e.Idprodus).HasColumnName("IDProdus");
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.IdvanzareDirecta).HasColumnName("IDVanzareDirecta");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.IdvanzareDirectaNavigation).WithMany(p => p.VanzariDirecteProduses)
                .HasForeignKey(d => d.IdvanzareDirecta)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_VanzariDirecteProduse_VanzariDirecte");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
