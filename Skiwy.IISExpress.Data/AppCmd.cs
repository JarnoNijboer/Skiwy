using System.Xml.Serialization;

using Skiwy.IISExpress.Data.Models;

namespace Skiwy.IISExpress.Data
{
	[XmlType(AnonymousType = true)]
	[XmlRoot("appcmd", Namespace = "", IsNullable = false)]
	public class AppCmd
	{
		[XmlElement("SITE")]
		public Site[] Sites { get; set; }
	}
}
