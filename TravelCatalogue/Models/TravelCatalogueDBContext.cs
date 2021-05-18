using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TravelCatalogue.Models
{
    public partial class TravelCatalogueDBContext : DbContext
    {
        public TravelCatalogueDBContext()
        {
        }

        public TravelCatalogueDBContext(DbContextOptions<TravelCatalogueDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attraction> Attractions { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Traveltip> Traveltips { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=TravelCatalogueDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attraction>(entity =>
            {
                entity.HasKey(e => e.AttractionId)
                    .HasName("PK__attracti__537C1CF2D4AC6597")
                    .IsClustered(false);

                entity.ToTable("attraction");

                entity.Property(e => e.AttractionId).HasColumnName("attraction_id");

                entity.Property(e => e.AttractionDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("attraction_description");

                entity.Property(e => e.AttractionImage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("attraction_image");

                entity.Property(e => e.AttractionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attraction_name");

                entity.Property(e => e.DestinationId).HasColumnName("destination_id");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Attractions)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("fk_attraction_destination");
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.DestinationId)
                    .HasName("PK__destinat__55015390A4F9863F")
                    .IsClustered(false);

                entity.ToTable("destination");

                entity.Property(e => e.DestinationId).HasColumnName("destination_id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CoverImage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("coverImage");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.ImageFlag)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("imageFlag");

                entity.Property(e => e.ImageSilhoutte)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("imageSilhoutte");
            });

            modelBuilder.Entity<Traveltip>(entity =>
            {
                entity.HasKey(e => e.TraveltipId)
                    .HasName("PK__travelti__A9B4F8791E9AD40A")
                    .IsClustered(false);

                entity.ToTable("traveltip");

                entity.Property(e => e.TraveltipId).HasColumnName("traveltip_id");

                entity.Property(e => e.DestinationId).HasColumnName("destination_id");

                entity.Property(e => e.TraveltipDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("traveltip_description");

                entity.Property(e => e.TraveltipImage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("traveltip_image");

                entity.Property(e => e.TraveltipName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("traveltip_name");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Traveltips)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("fk_traveltip_destination");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
