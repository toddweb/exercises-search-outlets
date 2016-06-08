namespace App.Commands
{
	public static class OutletSearchCLICommandFactory
	{
		public static ICLICommand Create(string command)
		{
			ICLICommand cliCommand;

			switch (command){
				case OutletSearchCLIConstants.Commands.Clear:
					cliCommand = new ClearCommand();
					break;
				case OutletSearchCLIConstants.Commands.Exit:
					cliCommand = new ExitCommand();
					break;
				case OutletSearchCLIConstants.Commands.Help:
					cliCommand = new HelpCommand();
					break;
				default:
					cliCommand = new SearchCommand(new OutletRepository());
					break;
			}

			return cliCommand;
		}
	}
}
