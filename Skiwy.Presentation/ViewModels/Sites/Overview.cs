using System.Collections.Generic;

using FirstFloor.ModernUI.Presentation;

using Skiwy.Data.Factory;
using Skiwy.Data.Interface;
using Skiwy.Data.Models;

namespace Skiwy.Presentation.ViewModels.Sites
{
	internal class Overview : NotifyPropertyChanged
	{
		private readonly ISiteFactory siteFactory;
		private ICollection<Site> sites;

		public Overview(ISiteFactory siteFactory)
		{
			this.siteFactory = new SiteFactory();
		}

		public ICollection<Site> Sites
		{
			get
			{
				if (this.sites == null)
				{
					this.sites = this.siteFactory.List().Result;
				}

				return this.sites;
			}
			set
			{
				this.sites = value;
				this.OnPropertyChanged("Sites");
			}
		}
	}
}
