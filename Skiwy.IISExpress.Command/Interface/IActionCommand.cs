using Skiwy.IISExpress.Host;

namespace Skiwy.IISExpress.Command.Interface
{
	public interface IActionCommand : ICommand
	{
		IFormat Format { get; }
		ProcessType ProcessType { get; }
		ITypeCommand TypeCommand { get; set; }
	}
}
