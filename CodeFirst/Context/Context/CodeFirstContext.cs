namespace CodeFirst.Context
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CodeFirstContext : DbContext
    {

        public CodeFirstContext()
            : base("name=CodeFirstContext")
        {

        }
        public virtual DbSet<Product> Product { get; set; }
    }
}