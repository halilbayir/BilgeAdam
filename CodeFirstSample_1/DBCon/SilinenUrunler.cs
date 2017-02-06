namespace CodeFirstSample_1.DBCon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SilinenUrunler")]
    public partial class SilinenUrunler
    {
        [Key]
        public int UrunID { get; set; }

        [StringLength(50)]
        public string UunAdi { get; set; }

        public int? KategoriID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fiyati { get; set; }
    }
}
