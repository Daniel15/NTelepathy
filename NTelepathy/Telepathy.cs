using System;
using DBus;
using NTelepathy.Dbus;

namespace NTelepathy
{
	public static class Telepathy
	{
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

