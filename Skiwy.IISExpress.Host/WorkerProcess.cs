using System;
using System.Diagnostics;

using Skiwy.IISExpress.Host.Interface;

namespace Skiwy.IISExpress.Host
{
	public class WorkerProcess : IWorkerProcess
	{
		private readonly ProcessStartInfo processInfo;
		private Process process;

		public WorkerProcess()
		{
			this.processInfo = new ProcessStartInfo
			{
				RedirectStandardError = true,
				RedirectStandardOutput = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = false
			};
		}

		public string Output { get; set; }
		public string Error { get; set; }

		public void Dispose()
		{
			this.process.Kill();
		}

		public bool Execute(string fileName, string argument)
		{
			try
			{
				this.processInfo.FileName = fileName;
				this.processInfo.Arguments = argument;
				this.process = Process.Start(this.processInfo);

				var outputReader = this.process.StandardOutput;
				var errorReader = this.process.StandardError;

				this.process.WaitForExit(60*30);

				if (this.process.HasExited)
				{
					this.Error = errorReader.ReadToEnd();
					this.Output = outputReader.ReadToEnd();
				}

				errorReader.Close();
				outputReader.Close();
			}
			catch (Exception)
			{
				return false;
			}

			return String.IsNullOrWhiteSpace(this.Error);
		}
	}
}
