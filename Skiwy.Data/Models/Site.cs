using System.Collections.Generic;

namespace Skiwy.Data.Models
{
	public class Site
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<string> Bindings { get; set; }
		public SiteState State { get; set; }

		public enum SiteState
		{
			Started,
			Stopped,
			Unknown
		}
	}
}
