namespace OktatasNyilvantarto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TpOktatasStatusz")]
    public partial class TpOktatasStatusz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TpOktatasStatusz()
        {
            TpOktatas = new HashSet<TpOktatas>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Ertek { get; set; }

        [StringLength(200)]
        public string Leiras { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TpOktatas> TpOktatas { get; set; }
    }
}
