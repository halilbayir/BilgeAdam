namespace CodeFirstSample_1.DBCon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sinif")]
    public partial class Sinif
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OgrNo { get; set; }

        [StringLength(30)]
        public string Adi { get; set; }

        [StringLength(30)]
        public string Soyadi { get; set; }

        public DateTime? DogumTarihi { get; set; }
    }
}
