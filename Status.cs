using DBus;
using NTelepathy.Dbus;

namespace NTelepathy
{
	/// <summary>
	/// Handles status updating
	/// </summary>
	public class Status
	{
		/// <summary>
		/// The DBUS connection
		/// </summary>
		private Connection _connection = Bus.Session;
		
		/// <summary>
		/// Update the status message of all accounts
		/// </summary>
		/// <param name='statusMessage'>Status message to set</param>
		public void UpdateAllAccounts(string statusMessage)
		{
			// Get all the valid accounts via the account manager
			AccountManagerProperties props = _connection.GetObject<AccountManagerProperties>(Constants.ACCOUNTMANAGER_BUS, new ObjectPath(Constants.ACCOUNTMANAGER_PATH));
			
			foreach (ObjectPath path in props.ValidAccounts)
			{
				UpdateAccount(path, statusMessage);			
			}
		}
		
		/// <summary>
		/// Update the status message of the specified account
		/// </summary>
		/// <param name='account'>The account to update</param>
		/// <param name='statusMessage'>Status message to set</param>
		private void UpdateAccount(ObjectPath account, string statusMessage)
		{
			AccountProperties props = _connection.GetObject<AccountProperties>(Constants.ACCOUNTMANAGER_BUS, account);
			
			// Get the connection for this account
			ObjectPath connection = props.Connection;
			// Update the presence
			ISimplePresence presence = _connection.GetObject<ISimplePresence>(ConnectionManagerBusName(connection), connection);
			presence.SetPresence("available", statusMessage);
		}
		
		/// <summary>
		/// Gets the bus name for the specified connection manager object path
		/// </summary>
		/// <returns>The bus name</returns>
		/// <param name='objectPath'>The object path</param>
		private static string ConnectionManagerBusName(ObjectPath objectPath)
		{
			// TODO: Is there a better (proper?) way to do this?
			
			// ObjectPath is eg. /org/freedesktop/Telepathy/Connection/gabble/jabber/daniel_40d15_2ebiz_2f3e9348f3
			// Connection manager type is 5th item (eg. "gabble")
			string connType = objectPath.ToString().Split('/')[5];
			
			return string.Format("org.freedesktop.Telepathy.ConnectionManager.{0}", connType);
		}
	}
}

