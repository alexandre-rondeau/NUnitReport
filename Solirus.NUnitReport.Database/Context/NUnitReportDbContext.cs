using System.Data.Entity;
using Solirus.NUnitReport.Database.Model;

namespace Solirus.NUnitReport.Database.Context
{
    public class NUnitReportDbContext : DbContext
    {
        public DbSet<TestResult> TestResults { get; set; }
    }
}
