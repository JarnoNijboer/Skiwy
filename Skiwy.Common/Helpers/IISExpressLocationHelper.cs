using System;
using System.IO;

namespace Skiwy.Common.Helpers
{
	public class IISExpressLocationHelper
	{
		protected const string ProgramDirectoryX86 = "Program Files (x86)";
		protected const string ProgramDirectoryX64 = "Program Files";
		protected const string IISExpressDirectory = "IIS Express";

		public static string AppDirectory
		{
			get
			{
				var directory = ProgramDirectoryX86;

				if (Environment.Is64BitOperatingSystem && Environment.Is64BitProcess)
				{
					directory = ProgramDirectoryX64;
				}

				return String.Format("{0}{1}", SystemDrive, Path.Combine(directory, IISExpressDirectory));
			}
		}

		protected static string SystemDrive
		{
			get
			{
				return Path.GetPathRoot(Environment.SystemDirectory);
			}
		}
	}
}
