namespace OktatasNyilvantarto
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DolgozoiKodok : DbContext
    {
        public DolgozoiKodok()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DolgKodok> DolgKodok { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
