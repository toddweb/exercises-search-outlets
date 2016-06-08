using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace App
{
	public interface IOutletRepository
	{
		IList<Contact> SearchContacts(string search);

		IList<Outlet> All();
	}

	public class OutletRepository : IOutletRepository
	{
		public IList<Contact> SearchContacts(string search)
		{
			var outlets = LoadOutlets();
			var contactBasedMatches = outlets.SelectMany(x => x.Contacts.Where(y => y.Profile.Contains(search) || y.LastName.Equals(search) || y.Title.Equals(search)));
			var outletBasedMatches = outlets.Where(x => x.Name.Contains(search)).SelectMany(x => x.Contacts);

			return contactBasedMatches.Union(outletBasedMatches).Distinct().OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
		}

		public IList<Outlet> All()
		{
			return LoadOutlets();
		}
		
		private IList<Outlet> LoadOutlets()
		{
			var serializer = new JavaScriptSerializer();
			var contacts = serializer.Deserialize<List<Contact>>(File.ReadAllText(ConfigurationManager.AppSettings["contactsFilePath"]));
			var outlets = serializer.Deserialize<List<Outlet>>(File.ReadAllText(ConfigurationManager.AppSettings["outletsFilePath"]));

			contacts.ForEach(x => outlets.First(y => y.Id == x.OutletId).Contacts.Add(x));

			return outlets;
		}
	}
}
