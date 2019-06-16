using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Vuja.KomunikacijaSaBazom.Domains
{
    public partial class VujaNBApatikeContext : DbContext
    {
        public VujaNBApatikeContext()
        {
        }

        public VujaNBApatikeContext(DbContextOptions<VujaNBApatikeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Arena> Arena { get; set; }
        public virtual DbSet<Brend> Brend { get; set; }
        public virtual DbSet<Igrac> Igrac { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Tim> Tim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=VujaNBApatike;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Arena>(entity =>
            {
                entity.Property(e => e.ArenaId)
                    .HasColumnName("ArenaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArenaBrojMesta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArenaGrad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArenaIme)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimId).HasColumnName("TimID");
            });

            modelBuilder.Entity<Brend>(entity =>
            {
                entity.Property(e => e.BrendId)
                    .HasColumnName("BrendID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrendIme)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrendSlika)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.BrendZemlja)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");
            });

            modelBuilder.Entity<Igrac>(entity =>
            {
                entity.Property(e => e.IgracId)
                    .HasColumnName("IgracID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GodisteIgrac).HasColumnType("datetime");

                entity.Property(e => e.ImeIgrac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.PrezimeIgrac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimId).HasColumnName("TimID");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.ModelId)
                    .HasColumnName("ModelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrendId).HasColumnName("BrendID");

                entity.Property(e => e.IgracId).HasColumnName("IgracID");

                entity.Property(e => e.ModelCena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelDatumIzlaska).HasColumnType("datetime");

                entity.Property(e => e.ModelIme)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tim>(entity =>
            {
                entity.Property(e => e.TimId)
                    .HasColumnName("TimID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArenaId).HasColumnName("ArenaID");

                entity.Property(e => e.IgracId).HasColumnName("IgracID");

                entity.Property(e => e.TimGrb).HasColumnType("image");

                entity.Property(e => e.TimIme)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimVlasnik)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
