using System.Collections.Generic;

using Skiwy.Data.Models;

namespace Skiwy.Data.Interface
{
	public interface ISiteFactory
	{
		ICollection<Site> List();
		Site Get(int id);
	}
}
