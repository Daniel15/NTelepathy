using System;
using DBus;
using NTelepathy.Dbus;

namespace NTelepathy
{
	/// <summary>
	/// Base Telepathy class
	/// </summary>
	public static class Telepathy
	{
		/// <summary>
		/// Get the Telepathy AccountManager
		/// </summary>
		public static AccountManager AccountManager
		{
			get
			{
				return DbusHelper.GetWithProperties<AccountManager>(
					Constants.ACCOUNTMANAGER_BUS,
					new ObjectPath(Constants.ACCOUNTMANAGER_PATH));
			}
		}
	}
}

