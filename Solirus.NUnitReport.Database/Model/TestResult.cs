using System.Xml.Linq;

namespace Solirus.NUnitReport.Database.Model
{
    public class TestResult
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public XElement XmlContent
        {
            get { return XElement.Parse(Content); }
            set { Content = value.ToString(); }
        }
    }
}
