using System.Collections.Generic;
using System.Threading.Tasks;

using Skiwy.Data.Models;

namespace Skiwy.Data.Interface
{
	public interface ISiteFactory
	{
		Task<List<Site>> List();
		Site Get(int id);
	}
}
