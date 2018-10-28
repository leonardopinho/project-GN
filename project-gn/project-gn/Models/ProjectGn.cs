namespace project_gn.Models
{
    using System.Data.Entity;

    public partial class ProjectGn : DbContext
    {
        public ProjectGn()
            : base("name=ProjectGn")
        {
        }

        public DbSet<CompanySize> CompanySize { get; set; }
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanySize>()
                .HasMany(e => e.Customer)
                .WithRequired(e => e.CompanySize)
                .HasForeignKey(e => e.id_company_size);
        }
    }
}
