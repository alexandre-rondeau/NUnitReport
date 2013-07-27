using System.Data.Entity.Migrations;

namespace Solirus.NUnitReport.Database.Context
{
    internal sealed class NUnitReportDbConfiguration : DbMigrationsConfiguration<NUnitReportDbContext>
    {
        public NUnitReportDbConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NUnitReportDbContext context)
        {
        }
    }
}
