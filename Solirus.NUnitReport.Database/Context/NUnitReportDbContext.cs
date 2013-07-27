using System.Data.Entity;
using Solirus.NUnitReport.Database.Model;

namespace Solirus.NUnitReport.Database.Context
{
    public class NUnitReportDbContext : DbContext
    {
        public DbSet<TestResult> TestResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestResult>()
                        .Property(x => x.Content)
                        .HasColumnType("xml");

            modelBuilder.Entity<TestResult>()
                        .Ignore(x => x.XmlContent);
        }
    }
}
