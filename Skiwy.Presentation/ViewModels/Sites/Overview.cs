using System.Collections.Generic;

using FirstFloor.ModernUI.Presentation;

using Skiwy.Data.Interface;
using Skiwy.Data.Models;

namespace Skiwy.Wpf.ViewModels.Sites
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
					this.sites = this.siteFactory.List();
				}

				return this.sites;
			}
			set
			{
				this.sites = value;
				OnPropertyChanged("Sites");
			}
		}
	}
}
