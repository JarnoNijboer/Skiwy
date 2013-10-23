namespace Skiwy.IISExpress.Command.Interface
{
	public interface ICommandFactory
	{
		object Exectute(ITypeCommand type, IActionCommand action);
	}
}
