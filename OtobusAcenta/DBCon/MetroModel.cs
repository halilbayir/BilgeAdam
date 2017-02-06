namespace OtobusAcenta.DBCon
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MetroModel : DbContext
    {
       
        public MetroModel()
            : base("name=MetroModel")
        {
        }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        
    }
}