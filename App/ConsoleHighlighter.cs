using System;

namespace App
{
	public static class SimpleConsoleHighlighter
	{
		public static void RenderContact(Contact contact, int index, Outlet outlet, string search)
		{
			Console.Write(string.Format("{0}. {1} ", index + 1, contact.FirstName));
			if (contact.LastName.Equals(search, StringComparison.InvariantCulture)) RenderValue(search, contact.LastName);
			else Console.WriteLine(contact.LastName);
			if (contact.Title.Equals(search, StringComparison.InvariantCulture)) RenderValue(search, contact.Title);
			else Console.WriteLine(contact.Title);
			RenderValue(search, outlet.Name);
			RenderValue(search, contact.Profile);
			Console.WriteLine();
		}

		private static void RenderValue(string search, string value)
		{
			var surroundingParts = value.Split(new string[1] { search }, StringSplitOptions.None);

			for (int i = 0; i < surroundingParts.Length; i++)
			{
				if (i > 0)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write(search);
					Console.ForegroundColor = OutletSearchCLIConstants.Colors.DefaultMessage;
				}

				Console.Write(surroundingParts[i]);
			}

			Console.WriteLine();
		}
	}
}
