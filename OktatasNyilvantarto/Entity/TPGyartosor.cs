namespace OktatasNyilvantarto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TPGyartosor")]
    public partial class TPGyartosor
    {
        [Key]
        public int GyartosorID { get; set; }

        [Required]
        [StringLength(100)]
        public string GyartosorNev { get; set; }
    }
}
