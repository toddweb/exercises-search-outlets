namespace App.Commands
{
	public class HelpCommand : ICLICommand
	{
		public void Run(string command)
		{
			OutletSearchCLI.WriteMessage("*******************************", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("*   News Outlet Search Help   *", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("*                             *", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("* 1. Enter search term(s)     *", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage(string.Format(@"* 2. Type ""{0}"" to clear      *", OutletSearchCLIConstants.Commands.Clear), OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage(string.Format(@"* 3. Type ""{0}"" to exit      *", OutletSearchCLIConstants.Commands.Exit), OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage(string.Format(@"* 4. Type ""{0}"" for options  *", OutletSearchCLIConstants.Commands.Help), OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("*                             *", OutletSearchCLIConstants.Colors.SystemMessage);
			OutletSearchCLI.WriteMessage("*******************************", OutletSearchCLIConstants.Colors.SystemMessage);
		}
	}
}
