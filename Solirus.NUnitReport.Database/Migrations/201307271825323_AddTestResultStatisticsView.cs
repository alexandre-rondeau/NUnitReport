namespace Solirus.NUnitReport.Database.Context
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestResultStatisticsView : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE VIEW [dbo].[TestResultsStatistics]
                    AS
                    SELECT [Id]
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case)', 'int') As Total
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Success''])', 'int') As Success
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Inconclusive''])', 'int') As Inconclusive
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''NotRunnable''])', 'int') As NotRunnable
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Skipped''])', 'int') As Skipped
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Ignored''])', 'int') As Ignored
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Failure''])', 'int') As Failure
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Error''])', 'int') As Error
	                      ,[Content].value('count(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case[@result=''Cancelled''])', 'int') As Cancelled
	                      ,[Content].value('(/*/@date)[1]', 'datetime') + [Content].value('(/*/@time)[1]', 'datetime') As [RunTime]
	                      ,[Content].value('sum(/test-results/test-suite/results/test-suite/results/test-suite/results/test-case/@time)', 'decimal(19,3)') As Duration
                      FROM [dbo].[TestResults]");
        }

        public override void Down()
        {
            Sql("DROP VIEW [dbo].[TestResultsStatistics]");
        }
    }
}
