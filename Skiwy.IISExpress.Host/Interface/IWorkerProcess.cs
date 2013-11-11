using System;

namespace Skiwy.IISExpress.Host.Interface
{
	public interface IWorkerProcess : IDisposable
	{
		string Output { get; set; }
		string Error { get; set; }

		bool Execute(string fileName, string argument);
	}
}
