using System;

namespace App
{
	class Program
	{
		static void Main(string[] args)
		{
			var cli = new OutletSearchCLI();
			var command = string.Empty;

			Console.Title = "News Outlet Search";
			cli.RenderMenu();

			try {
				while ((command = cli.AcceptCommand()) != OutletSearchCLIConstants.Commands.Exit) cli.ExecuteCommand(command);
			}
			catch (Exception e) {
				OutletSearchCLI.WriteMessage("The program has experienced an unrecoverable error, press enter to exit. The error details are:", OutletSearchCLIConstants.Colors.ErrorMessage);
				Console.WriteLine();
				OutletSearchCLI.WriteMessage(e.ToString(), OutletSearchCLIConstants.Colors.ErrorMessage);
				Console.ReadLine();
			}
		}
	}
}
