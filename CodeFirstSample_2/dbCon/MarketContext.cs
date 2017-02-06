namespace CodeFirstSample_2.dbCon
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MarketContext : DbContext
    {
        
        public MarketContext()
            : base("name=MarketContext")
        {

        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.ProductPrice).HasColumnType("Money");
        }
    }

}