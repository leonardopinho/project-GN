using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using project_gn.Models;

namespace project_gn.Context
{
    public class DataContext : DbContext
    {
        public DbSet<CompanySize> companySize { get; set; }
        public DbSet<Customer> customer { get; set; }

        public DataContext(): base("gn-context"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}