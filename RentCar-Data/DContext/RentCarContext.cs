using Microsoft.EntityFrameworkCore;
using RentCar_Model.Models;

namespace RentCar_Data.DContext
{
    public partial class RentCarContext : DbContext
    {
        public RentCarContext()
        {
        }

        public RentCarContext(DbContextOptions<RentCarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agence> Agences { get; set; } = null!;
        public virtual DbSet<Carburant> Carburants { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Conducteur> Conducteurs { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Listenoir> Listenoirs { get; set; } = null!;
        public virtual DbSet<Marque> Marques { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Serie> Series { get; set; } = null!;
        public virtual DbSet<Typeclient> Typeclients { get; set; } = null!;
        public virtual DbSet<Vehicule> Vehicules { get; set; } = null!;
        public virtual DbSet<Ville> Villes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local); Database=RentCar;Persist Security Info=False; User ID=sa;Password=pop2009$mcrp;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agence>(entity =>
            {
                entity.HasKey(e => e.IdAgen)
                    .IsClustered(false);

                entity.ToTable("AGENCE");

                entity.Property(e => e.IdAgen)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_AGEN");

                entity.Property(e => e.EmailAgen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_AGEN");

                entity.Property(e => e.IceAgen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ICE_AGEN");

                entity.Property(e => e.IdVil).HasColumnName("ID_VIL");

                entity.Property(e => e.Identitycode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IDENTITYCODE");

                entity.Property(e => e.IfAgen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IF_AGEN");

                entity.Property(e => e.LogoAgen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOGO_AGEN");

                entity.Property(e => e.NomAgen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_AGEN");

                entity.Property(e => e.PatenteAgen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PATENTE_AGEN");

                entity.Property(e => e.SitewebAgen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SITEWEB_AGEN");

                entity.Property(e => e.TelFixAgen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEL_FIX_AGEN");

                entity.Property(e => e.TelMobileAgen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEL_MOBILE_AGEN");

                entity.Property(e => e.AdresseAgen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_AGEN");

                entity.HasOne(d => d.IdVilNavigation)
                    .WithMany(p => p.Agences)
                    .HasForeignKey(d => d.IdVil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGENCE_VILLEAGEN_VILLE");
            });

            modelBuilder.Entity<Carburant>(entity =>
            {
                entity.HasKey(e => e.IdCar)
                    .IsClustered(false);

                entity.ToTable("CARBURANT");

                entity.Property(e => e.IdCar)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CAR");

                entity.Property(e => e.LibCar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LIB_CAR");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdCli)
                    .IsClustered(false);

                entity.ToTable("CLIENT");

                entity.Property(e => e.IdCli)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_CLI");

                entity.Property(e => e.AdresseCli)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_CLI");

                entity.Property(e => e.CinCli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIN_CLI");

                entity.Property(e => e.IdAgen).HasColumnName("ID_AGEN");

                entity.Property(e => e.IdTypecli).HasColumnName("ID_TYPECLI");

                entity.Property(e => e.IdVil).HasColumnName("ID_VIL");

                entity.Property(e => e.NomCli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_CLI");

                entity.Property(e => e.PrenomCli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM_CLI");

                entity.Property(e => e.TelCli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEL_CLI");

                entity.HasOne(d => d.IdAgenNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdAgen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_CLIENTAGE_AGENCE");

                entity.HasOne(d => d.IdTypecliNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdTypecli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_TPCLIENT_TYPECLIE");

                entity.HasOne(d => d.IdVilNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.IdVil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLIENT_VILLECLIE_VILLE");
            });

            modelBuilder.Entity<Conducteur>(entity =>
            {
                entity.HasKey(e => e.IdCond)
                    .IsClustered(false);

                entity.ToTable("CONDUCTEUR");

                entity.Property(e => e.IdCond)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_COND");

                entity.Property(e => e.AdresseCond)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_COND");

                entity.Property(e => e.CinCond)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CIN_COND");

                entity.Property(e => e.IdTypecli).HasColumnName("ID_TYPECLI");

                entity.Property(e => e.NomCond)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_COND");

                entity.Property(e => e.PrenomCond)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PRENOM_COND");

                entity.Property(e => e.TelCond)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TEL_COND");

                entity.HasOne(d => d.IdTypecliNavigation)
                    .WithMany(p => p.Conducteurs)
                    .HasForeignKey(d => d.IdTypecli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CONDUCTE_CONDUCTEU_TYPECLIE");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.IdDoc)
                    .IsClustered(false);

                entity.ToTable("DOCUMENT");

                entity.Property(e => e.IdDoc)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_DOC");

                entity.Property(e => e.CheminDoc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CHEMIN_DOC");

                entity.Property(e => e.DtEnreDoc)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_ENRE_DOC");

                entity.Property(e => e.IdAgen).HasColumnName("ID_AGEN");

                entity.Property(e => e.IdCli).HasColumnName("ID_CLI");

                entity.Property(e => e.IdCond).HasColumnName("ID_COND");

                entity.Property(e => e.IdVeh).HasColumnName("ID_VEH");

                entity.Property(e => e.NomDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOM_DOC");

                entity.HasOne(d => d.IdCondNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.IdCond)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCUMENT_DOCUMENTC_CONDUCTE");

                entity.HasOne(d => d.IdVehNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.IdVeh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOCUMENT_DOCUMENTV_VEHICULE");
            });

            modelBuilder.Entity<Listenoir>(entity =>
            {
                entity.HasKey(e => new { e.IdAgen, e.IdCli })
                    .IsClustered(false);

                entity.ToTable("LISTENOIR");

                entity.Property(e => e.IdAgen).HasColumnName("ID_AGEN");

                entity.Property(e => e.IdCli).HasColumnName("ID_CLI");

                entity.Property(e => e.DtRemarqueLst)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_REMARQUE_LST");

                entity.Property(e => e.IdLst).HasColumnName("ID_LST");

                entity.Property(e => e.RemarqueLst)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARQUE_LST");

                entity.HasOne(d => d.IdAgenNavigation)
                    .WithMany(p => p.Listenoirs)
                    .HasForeignKey(d => d.IdAgen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LISTENOI_LISTENOIR_AGENCE");

                entity.HasOne(d => d.IdCliNavigation)
                    .WithMany(p => p.Listenoirs)
                    .HasForeignKey(d => d.IdCli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LISTENOI_LISTENOIR_CLIENT");
            });

            modelBuilder.Entity<Marque>(entity =>
            {
                entity.HasKey(e => e.IdMar)
                    .IsClustered(false);

                entity.ToTable("MARQUE");

                entity.Property(e => e.IdMar)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_MAR");

                entity.Property(e => e.NomMar)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_MAR");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.IdRes)
                    .IsClustered(false);

                entity.ToTable("RESERVATION");

                entity.Property(e => e.IdRes)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_RES");

                entity.Property(e => e.AdresseLivraison)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_LIVRAISON");

                entity.Property(e => e.AdresseRetour)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADRESSE_RETOUR");

                entity.Property(e => e.DtDebutRes)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_DEBUT_RES");

                entity.Property(e => e.DtFinRes)
                    .HasColumnType("datetime")
                    .HasColumnName("DT_FIN_RES");

                entity.Property(e => e.DureeRes).HasColumnName("DUREE_RES");

                entity.Property(e => e.IdCli).HasColumnName("ID_CLI");

                entity.Property(e => e.IdVeh).HasColumnName("ID_VEH");

                entity.Property(e => e.IdVil).HasColumnName("ID_VIL");

                entity.HasOne(d => d.IdCliNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdCli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESERVAT_RESERVATI_CLIENT");

                entity.HasOne(d => d.IdVehNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdVeh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESERVAT_RESERVATI_VEHICULE");

                entity.HasOne(d => d.IdVilNavigation)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.IdVil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESERVAT_VILLERESE_VILLE");
            });

            modelBuilder.Entity<Serie>(entity =>
            {
                entity.HasKey(e => e.IdSerie)
                    .IsClustered(false);

                entity.ToTable("SERIE");

                entity.Property(e => e.IdSerie)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_SERIE");

                entity.Property(e => e.IdMar).HasColumnName("ID_MAR");

                entity.Property(e => e.NomSerie)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_SERIE");

                entity.HasOne(d => d.IdMarNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.IdMar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SERIE_MARQUEVEH_MARQUE");
            });

            modelBuilder.Entity<Typeclient>(entity =>
            {
                entity.HasKey(e => e.IdTypecli)
                    .IsClustered(false);

                entity.ToTable("TYPECLIENT");

                entity.Property(e => e.IdTypecli)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_TYPECLI");

                entity.Property(e => e.NomTypecli)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_TYPECLI");
            });

            modelBuilder.Entity<Vehicule>(entity =>
            {
                entity.HasKey(e => e.IdVeh)
                    .IsClustered(false);

                entity.ToTable("VEHICULE");

                entity.Property(e => e.IdVeh)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_VEH");

                entity.Property(e => e.IdAgen).HasColumnName("ID_AGEN");

                entity.Property(e => e.IdCar).HasColumnName("ID_CAR");

                entity.Property(e => e.IdSerie).HasColumnName("ID_SERIE");

                entity.Property(e => e.MatriVeh)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MATRI_VEH");

                entity.HasOne(d => d.IdAgenNavigation)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.IdAgen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULE_VEHICULEA_AGENCE");

                entity.HasOne(d => d.IdCarNavigation)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.IdCar)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULE_CARBURANT_CARBURAN");

                entity.HasOne(d => d.IdSerieNavigation)
                    .WithMany(p => p.Vehicules)
                    .HasForeignKey(d => d.IdSerie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEHICULE_ASSOCIATI_SERIE");
            });

            modelBuilder.Entity<Ville>(entity =>
            {
                entity.HasKey(e => e.IdVil)
                    .IsClustered(false);

                entity.ToTable("VILLE");

                entity.Property(e => e.IdVil)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_VIL");

                entity.Property(e => e.NomVil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NOM_VIL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
