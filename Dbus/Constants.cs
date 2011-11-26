using System;

namespace NTelepathy.Dbus
{
	/// <summary>
	/// Various DBus constants
	/// </summary>
	public abstract class Constants
	{
		/// <summary>
		/// Bus for the account manager.
		/// </summary>
		public const string ACCOUNTMANAGER_BUS = "org.freedesktop.Telepathy.AccountManager";
		/// <summary>
		/// Path for the account manager.
		/// </summary>
		public const string ACCOUNTMANAGER_PATH = "/org/freedesktop/Telepathy/AccountManager";
		/// <summary>
		/// Interface for the account manager.
		/// </summary>
		public const string ACCOUNTMANAGER_INTERFACE = "org.freedesktop.Telepathy.AccountManager";
		/// <summary>
		/// Interface for accounts.
		/// </summary>
		public const string ACCOUNT_INTERFACE = "org.freedesktop.Telepathy.Account";
		
		public const string SIMPLEPRESENCE_INTERFACE = "org.freedesktop.Telepathy.Connection.Interface.SimplePresence";
	}
}

