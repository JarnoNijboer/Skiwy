using System.Threading.Tasks;

namespace Skiwy.IISExpress.Command.Interface
{
	public interface ICommandFactory
	{
		Task<T> Execute<T>(ITypeCommand type, IActionCommand action) where T : class;
		Task<T> Execute<T>(IActionCommand action) where T : class;
	}
}
