using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Skiwy.Data.Interface;
using Skiwy.Data.Models;
using Skiwy.IISExpress.Command.Command;
using Skiwy.IISExpress.Command.Factory;
using Skiwy.IISExpress.Command.Interface;
using Skiwy.IISExpress.Data;

namespace Skiwy.Data.Factory
{
	public class SiteFactory : ISiteFactory
	{
		private readonly ICommandFactory commandFactory;

		public SiteFactory()
		{
			this.commandFactory = new CommandFactory(TypeCommand.Site);
		}

		public async Task<List<Site>> List()
		{
			var appCmd = await this.commandFactory.Execute<AppCmd>(ActionCommand.List);

			var result = appCmd.Sites.Select(Map);

			return result.ToList();
		}

		// TODO Use AutoMapper
		private static Site Map(IISExpress.Data.Models.Site site)
		{
			return new Site
			{
				Id = site.Id,
				Name = site.Name,
				State = (Site.SiteState) Enum.Parse(typeof (Site.SiteState), site.State),
				Bindings = new List<string>
				{
					site.Bindings
				}
			};
		}

		public Site Get(int id)
		{
			return null;
		}
	}

	//public abstract class Mapper<TM, TE>
	//	where TM : class
	//	where TE : class
	//{
	//	protected Mapper()
	//	{
	//		Mapper.CreateMap<TM, TE>();
	//		Mapper.CreateMap<TE, TM>();
	//	}

	//	public virtual TE Map(TM item)
	//	{
	//		return Mapper.Map<TM, TE>(item);
	//	}

	//	public virtual TM Map(TE item)
	//	{
	//		return Mapper.Map<TE, TM>(item);
	//	}
	//}
}
