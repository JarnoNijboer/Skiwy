using System;
using System.Threading.Tasks;

using Skiwy.Common.Utils;
using Skiwy.IISExpress.Command.Common;
using Skiwy.IISExpress.Command.Interface;
using Skiwy.IISExpress.Host;
using Skiwy.IISExpress.Host.Interface;

namespace Skiwy.IISExpress.Command.Factory
{
	public class CommandFactory : ICommandFactory
	{
		private readonly IWorkerProcess worker;
		private ITypeCommand typeCommand;

		public CommandFactory(ITypeCommand typeCommand)
		{
			this.worker = new WorkerProcess();
			this.typeCommand = typeCommand;
		}
		public async Task<T> Execute<T>(ITypeCommand type, IActionCommand action) where T : class
		{
			this.typeCommand = type;

			return await this.Execute<T>(action);
		}

		public async Task<T> Execute<T>(IActionCommand action) where T : class
		{
			action.TypeCommand = this.typeCommand;

			var result = await Task.Factory.StartNew(() => this.Run<T>(action));

			return result;
		}

		private T Run<T>(IActionCommand action) where T : class
		{
			T result = null;

			if (this.worker.Execute(action.ProcessType.Executable, action.Command))
			{
				if (action.Format == Format.Xml)
				{
					result = Utility.Deserialize<T>(this.worker.Output);
				}
				else if (action.Format == Format.Text)
				{
					result = this.worker.Output as T;
				}
			}

			return result;
		}
	}
}
