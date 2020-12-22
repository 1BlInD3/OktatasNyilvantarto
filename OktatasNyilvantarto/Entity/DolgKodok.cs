namespace OktatasNyilvantarto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DolgKodok")]
    public partial class DolgKodok
    {
        [StringLength(10)]
        public string CardCode { get; set; }

        [StringLength(10)]
        public string Key1 { get; set; }

        [StringLength(10)]
        public string TSz { get; set; }

        [StringLength(100)]
        public string TextDescription { get; set; }

        [StringLength(10)]
        public string CodeDepFld1 { get; set; }

        [StringLength(10)]
        public string CodeDepFld2 { get; set; }

        public int? StatusAkt { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? DirIndir { get; set; }

        [StringLength(100)]
        public string ExtName { get; set; }

        [StringLength(1)]
        public string Potty { get; set; }

        [StringLength(7)]
        public string BelepIdo { get; set; }

        [Key]
        public int IdColumn { get; set; }
    }
}
