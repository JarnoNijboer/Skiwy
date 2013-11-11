using System.Xml.Serialization;

namespace Skiwy.IISExpress.Data.Models
{
	[XmlType(AnonymousType = true)]
	public class Site
	{
		[XmlAttribute("SITE.NAME")]
		public string Name { get; set; }

		[XmlAttribute("SITE.ID")]
		public int Id { get; set; }

		[XmlAttribute("bindings")]
		public string Bindings { get; set; }

		[XmlAttribute("state")]
		public string State { get; set; }
	}
}