namespace OktatasNyilvantarto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TpOktatas
    {
        public int ID { get; set; }

        public int Sorszam { get; set; }

        [Required]
        [StringLength(200)]
        public string Megnevezes { get; set; }

        public bool Tervezett { get; set; }

        public bool Belso { get; set; }

        public int TipusID { get; set; }

        public int StatuszID { get; set; }

        public int GyakorisagID { get; set; }

        public decimal Oraszam { get; set; }

        [Required]
        [StringLength(50)]
        public string Igenylo { get; set; }

        [Column(TypeName = "date")]
        public DateTime LetrehozasDatum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LezarasDatum { get; set; }

        public virtual TpOktatasGyakorisag TpOktatasGyakorisag { get; set; }

        public virtual TpOktatasStatusz TpOktatasStatusz { get; set; }

        public virtual TpOktatasTipus TpOktatasTipus { get; set; }
    }
}
