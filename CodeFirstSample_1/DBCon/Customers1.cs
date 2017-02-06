namespace CodeFirstSample_1.DBCon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers1
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(25)]
        public string CustomerName { get; set; }

        [StringLength(25)]
        public string ContactName { get; set; }

        [StringLength(100)]
        public string Adress { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        public int? PostalCode { get; set; }

        [StringLength(20)]
        public string Country { get; set; }
    }
}
