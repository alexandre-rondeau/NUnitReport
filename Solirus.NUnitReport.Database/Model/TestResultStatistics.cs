using System;

namespace Solirus.NUnitReport.Database.Model
{
    public class TestResultStatistics
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public int Success { get; set; }
        public int Inconclusive { get; set; }
        public int NotRunnable { get; set; }
        public int Skipped { get; set; }
        public int Ignored { get; set; }
        public int Failure { get; set; }
        public int Error { get; set; }
        public int Cancelled { get; set; }
        public DateTime RunTime { get; set; }
        public decimal Duration { get; set; }
    }
}