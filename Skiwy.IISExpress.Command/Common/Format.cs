using Skiwy.IISExpress.Command.Interface;

namespace Skiwy.IISExpress.Command.Common
{
	public class Format : IFormat
	{
		public Format(string command)
		{
			this.Command = command;
		}

		public string Command { get; private set; }

		#region Formats
		private static readonly Format xmlFormat = new Format("/xml");
		private static readonly Format textFormat = new Format("/text");

		public static Format Xml
		{
			get { return xmlFormat; }
		}

		public static Format Text
		{
			get { return textFormat; }
		}
		#endregion
	}
}
