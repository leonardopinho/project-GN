namespace project_gn.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProjectGn : DbContext
    {
        public ProjectGn()
            : base("name=ProjectGn")
        {
        }

        public virtual DbSet<CompanySize> CompanySize { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanySize>()
                .HasMany(e => e.Customer)
                .WithRequired(e => e.CompanySize)
                .HasForeignKey(e => e.id_company_size);
        }
    }
}
