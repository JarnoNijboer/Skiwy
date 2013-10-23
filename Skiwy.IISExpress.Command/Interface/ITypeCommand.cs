namespace Skiwy.IISExpress.Command.Interface
{
	// ReSharper disable once InconsistentNaming
	public abstract class ITypeCommand : ICommand
	{
		private readonly string command;

		protected ITypeCommand(string command)
		{
			this.command = command;
		}

		public string Command
		{
			get { return this.command; }
		}
	}
}
