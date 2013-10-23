using System;

using Skiwy.IISExpress.Command.Interface;

namespace Skiwy.IISExpress.Command
{
	public class ActionCommand : IActionCommand
	{
		private readonly string command;
		private readonly IFormat format;

		public ActionCommand(string command, IFormat format)
		{
			this.command = command;
			this.format = format;
		}

		public string Command
		{
			get { return String.Format("{0} {1} {2}", this.command, this.TypeCommand.Command, this.Format.Command); }
		}

		public IFormat Format
		{
			get { return this.format; }
		}

		public ITypeCommand TypeCommand { get; set; }

		#region Commands
		private static readonly ActionCommand listCommand = new ActionCommand("list", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand addCommand = new ActionCommand("add", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand setCommand = new ActionCommand("set", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand deleteCommand = new ActionCommand("delete", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand searchCommand = new ActionCommand("search", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand lockCommand = new ActionCommand("lock", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand unlockCommand = new ActionCommand("unlock", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand clearCommand = new ActionCommand("clear", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand resetCommand = new ActionCommand("reset", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand installCommand = new ActionCommand("install", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand uninstallCommand = new ActionCommand("uninstall", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand configureCommand = new ActionCommand("configure", IISExpress.Command.Format.Xml);
		private static readonly ActionCommand inspectCommand = new ActionCommand("inspect", IISExpress.Command.Format.Xml);

		public static ActionCommand List
		{
			get { return listCommand; }
		}

		public static ActionCommand Add
		{
			get { return addCommand; }
		}

		public static ActionCommand Set
		{
			get { return setCommand; }
		}

		public static ActionCommand Delete
		{
			get { return deleteCommand; }
		}

		public static ActionCommand Search
		{
			get { return searchCommand; }
		}

		public static ActionCommand Lock
		{
			get { return lockCommand; }
		}

		public static ActionCommand Unlock
		{
			get { return unlockCommand; }
		}

		public static ActionCommand Clear
		{
			get { return clearCommand; }
		}

		public static ActionCommand Reset
		{
			get { return resetCommand; }
		}

		public static ActionCommand Install
		{
			get { return installCommand; }
		}

		public static ActionCommand Uninstall
		{
			get { return uninstallCommand; }
		}

		public static ActionCommand Configure
		{
			get { return configureCommand; }
		}

		public static ActionCommand Inspect
		{
			get { return inspectCommand; }
		}
		#endregion
	}
}
