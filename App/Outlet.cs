using System.Collections.Generic;
using System.Linq;

namespace App
{
	public class Outlet
	{
		public Outlet()
		{
			Contacts = new List<Contact>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public IList<Contact> Contacts { get; set; }

		public void AddContact(Contact contact)
		{
			if (Contacts.Any(x => x.Id == contact.Id)) return;

			Contacts.Add(contact);
		}
	}
}
