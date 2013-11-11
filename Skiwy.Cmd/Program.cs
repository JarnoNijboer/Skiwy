using System;

using Skiwy.Common.Utils;
using Skiwy.Data.Factory;
using Skiwy.IISExpress.Data;
using Skiwy.IISExpress.Data.Models;

namespace Skiwy.Cmd
{
	class Program
	{
		static void Main(string[] args)
		{
			var factory = new SiteFactory();

			var t = factory.List().Result;

			//var s = new AppCmd
			//{
			//	Sites = new[]
			//	{
			//		new Site
			//		{
			//			Id = 1,
			//			Name = "a",
			//			Bindings = "b",
			//			State = "Unknown"
			//		}
			//	}
			//};

			//var u = Utility.Deserialize<AppCmd>(Utility.Serialize(s));
			
			Console.ReadLine();
		}
	}
}
