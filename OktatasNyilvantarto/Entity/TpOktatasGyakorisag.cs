namespace OktatasNyilvantarto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TpOktatasGyakorisag")]
    public partial class TpOktatasGyakorisag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TpOktatasGyakorisag()
        {
            TpOktatas = new HashSet<TpOktatas>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ertek { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TpOktatas> TpOktatas { get; set; }
    }
}
