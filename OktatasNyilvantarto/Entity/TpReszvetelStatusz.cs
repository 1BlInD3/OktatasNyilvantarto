namespace OktatasNyilvantarto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TpReszvetelStatusz")]
    public partial class TpReszvetelStatusz
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Ertek { get; set; }

        [StringLength(200)]
        public string Leiras { get; set; }
    }
}
