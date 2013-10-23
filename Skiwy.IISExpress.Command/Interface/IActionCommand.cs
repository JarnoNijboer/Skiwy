namespace Skiwy.IISExpress.Command.Interface
{
	public interface IActionCommand : ICommand
	{
		IFormat Format { get; }
		ITypeCommand TypeCommand { get; set; }
	}
}
