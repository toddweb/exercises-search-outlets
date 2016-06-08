using System;

namespace App.Commands
{
	public class ClearCommand : ICLICommand
	{
		public void Run(string command)
		{
			Console.Clear();
		}
	}
}
