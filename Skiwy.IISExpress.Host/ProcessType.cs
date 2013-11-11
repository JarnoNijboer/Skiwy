using System.IO;

using Skiwy.Common.Helpers;
using Skiwy.IISExpress.Host.Interface;

namespace Skiwy.IISExpress.Host
{
	public class ProcessType : IProcessType
	{
		private readonly string executable;

		public ProcessType(string executable)
		{
			this.executable = executable;
		}

		public string Executable
		{
			get
			{
				return Path.Combine(IISExpressLocationHelper.AppDirectory, this.executable);
			}
		}

		#region Items
		private static ProcessType appCmd;
		private static ProcessType iisExpress;

		public static ProcessType AppCmd
		{
			get { return appCmd ?? (appCmd = new ProcessType("appcmd.exe")); }
		}

		public static ProcessType IISExpress
		{
			get { return iisExpress ?? (iisExpress = new ProcessType("iisexpress.exe")); }
		}
		#endregion
	}
}
