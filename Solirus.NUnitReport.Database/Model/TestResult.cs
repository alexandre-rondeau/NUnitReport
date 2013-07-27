using System.ComponentModel.DataAnnotations.Schema;

namespace Solirus.NUnitReport.Database.Model
{
    public class TestResult
    {
        public int Id { get; set; }

        [Column(TypeName="xml")]
        public string Content { get; set; }
    }
}
