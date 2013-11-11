using System;

using Skiwy.IISExpress.Command.Interface;
using Skiwy.IISExpress.Host;

namespace Skiwy.IISExpress.Command.Command
{
	public class ActionCommand : IActionCommand
	{
		private readonly string command;
		private readonly IFormat format;
		private readonly ProcessType process;

		public ActionCommand(string command, IFormat format, ProcessType process)
		{
			this.command = command;
			this.format = format;
			this.process = process;
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

		public ProcessType ProcessType
		{
			get { return this.process; }
		}

		#region Commands
		private static readonly ActionCommand listCommand = new ActionCommand("list", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand addCommand = new ActionCommand("add", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand setCommand = new ActionCommand("set", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand deleteCommand = new ActionCommand("delete", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand searchCommand = new ActionCommand("search", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand lockCommand = new ActionCommand("lock", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand unlockCommand = new ActionCommand("unlock", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand clearCommand = new ActionCommand("clear", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand resetCommand = new ActionCommand("reset", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand installCommand = new ActionCommand("install", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand uninstallCommand = new ActionCommand("uninstall", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand configureCommand = new ActionCommand("configure", Common.Format.Xml, ProcessType.AppCmd);
		private static readonly ActionCommand inspectCommand = new ActionCommand("inspect", Common.Format.Xml, ProcessType.AppCmd);

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
