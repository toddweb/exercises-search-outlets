using App.Commands;
using System;

namespace App
{
	public class OutletSearchCLI
	{
		public string AcceptCommand()
		{
			return Console.ReadLine();
		}

		public void ExecuteCommand(string command)
		{
			if (string.IsNullOrWhiteSpace(command)) {
				WriteMessage("You must enter a search term or command", OutletSearchCLIConstants.Colors.SystemMessage);
				return;
			}

			RunCommand(command);
		}

		public void RenderMenu()
		{
			RunCommand(OutletSearchCLIConstants.Commands.Help);
		}

		public static void WriteMessage(string message, ConsoleColor color = OutletSearchCLIConstants.Colors.DefaultMessage)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ForegroundColor = OutletSearchCLIConstants.Colors.DefaultMessage;
		}

		private void RunCommand(string command)
		{
			OutletSearchCLICommandFactory.Create(command).Run(command);
		}
	}
}
