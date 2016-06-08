using System;
using System.Linq;

namespace App.Commands
{
	public class SearchCommand : ICLICommand
	{
		private IOutletRepository repository;

		public SearchCommand(IOutletRepository repository)
		{
			this.repository = repository;
		}

		public void Run(string command)
		{
			var results = repository.SearchContacts(command);

			Console.WriteLine();
			OutletSearchCLI.WriteMessage("*******************", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("* Search Results: *", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("*******************", OutletSearchCLIConstants.Colors.SystemMessage);
			Console.WriteLine();

			if (!results.Any())
			{
				OutletSearchCLI.WriteMessage("No contacts found", OutletSearchCLIConstants.Colors.SystemMessage);
				Console.WriteLine();
				return;
			}

			var allOutlets = repository.All();

			for (int i = 0; i < results.Count(); i++)
				SimpleConsoleHighlighter.RenderContact(results[i], i, allOutlets.First(x => x.Id == results[i].OutletId), command);
		}
	}
}
