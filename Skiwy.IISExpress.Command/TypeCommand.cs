using Skiwy.IISExpress.Command.Interface;

namespace Skiwy.IISExpress.Command
{
	public class TypeCommand : ITypeCommand
	{
		public TypeCommand(string command) : base(command) {}

		#region Commands
		private static readonly TypeCommand appCommand = new TypeCommand("app");
		private static readonly TypeCommand vdirCommand = new TypeCommand("vdir");
		private static readonly TypeCommand siteCommand = new TypeCommand("sites");
		private static readonly TypeCommand appPoolCommand = new TypeCommand("apppool");
		private static readonly TypeCommand configCommand = new TypeCommand("config");
		private static readonly TypeCommand moduleCommand = new TypeCommand("module");
		private static readonly TypeCommand traceCommand = new TypeCommand("trace");

		public static TypeCommand App
		{
			get { return appCommand; }
		}

		public static TypeCommand VirtualDirectory
		{
			get { return vdirCommand; }
		}

		public static TypeCommand Site
		{
			get { return siteCommand; }
		}

		public static TypeCommand ApplicationPool
		{
			get { return appPoolCommand; }
		}

		public static TypeCommand Config
		{
			get { return configCommand; }
		}

		public static TypeCommand Module
		{
			get { return moduleCommand; }
		}

		public static TypeCommand Trace
		{
			get { return traceCommand; }
		}
		#endregion
	}
}
