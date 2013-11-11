using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Skiwy.Common.Utils
{
	public class Utility
	{
		public static T Deserialize<T>(string output)
		{
			var xmlSerializer = new XmlSerializer(typeof(T));

			var encoding = new UTF8Encoding();
			var byteArray = encoding.GetBytes(output);

			using (var memStrm = new MemoryStream(byteArray))
			{
				return (T)xmlSerializer.Deserialize(memStrm);
			}
		}

		public static string Serialize<T>(T instance)
		{
			var xml = new XmlSerializer(typeof(T));
			var settings = new XmlWriterSettings
			{
				Indent = true,
				IndentChars = "  ",
				Encoding = new UnicodeEncoding(false, false),
				OmitXmlDeclaration = true
			};

			var sb = new StringBuilder();
			using (var writer = XmlWriter.Create(sb, settings))
			{
				xml.Serialize(writer, instance);
			}
			
			return sb.ToString();
		}
	}
}
