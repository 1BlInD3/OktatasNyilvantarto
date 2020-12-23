namespace OktatasNyilvantarto
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TP : DbContext
    {
        public TP()
            : base("name=TP")
        {
        }

        public virtual DbSet<TPGyartosor> TPGyartosor { get; set; }
        public virtual DbSet<TpOktatas> TpOktatas { get; set; }
        public virtual DbSet<TpOktatasGyakorisag> TpOktatasGyakorisag { get; set; }
        public virtual DbSet<TpOktatasStatusz> TpOktatasStatusz { get; set; }
        public virtual DbSet<TpOktatasTipus> TpOktatasTipus { get; set; }
        public virtual DbSet<TpReszvetelStatusz> TpReszvetelStatusz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TpOktatas>()
                .Property(e => e.Oraszam)
                .HasPrecision(4, 1);

            modelBuilder.Entity<TpOktatasGyakorisag>()
                .HasMany(e => e.TpOktatas)
                .WithRequired(e => e.TpOktatasGyakorisag)
                .HasForeignKey(e => e.GyakorisagID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TpOktatasStatusz>()
                .HasMany(e => e.TpOktatas)
                .WithRequired(e => e.TpOktatasStatusz)
                .HasForeignKey(e => e.StatuszID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TpOktatasTipus>()
                .HasMany(e => e.TpOktatas)
                .WithRequired(e => e.TpOktatasTipus)
                .HasForeignKey(e => e.TipusID)
                .WillCascadeOnDelete(false);
        }
    }
}
