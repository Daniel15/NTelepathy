using System;
using System.Collections.Generic;
using DBus;
using NTelepathy.Dbus;

namespace NTelepathy
{
	/// <summary>
	/// Telepathy AccountManager interface. Handles management of accounts.
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Account_Manager.html</remarks>
	public abstract class AccountManager : DbusBase, IAccountManager
	{
		/// <summary>
		/// Get all the valid accounts this account manager knows about
		/// </summary>
		/// <value>The accounts</value>
		public IEnumerable<IAccount> ValidAccounts
		{	
			get
			{
				ObjectPath[] paths = GetProperty<ObjectPath[]>(Constants.ACCOUNTMANAGER_INTERFACE, "ValidAccounts");
				return DbusHelper.GetWithProperties<Account>(Constants.ACCOUNTMANAGER_BUS, paths);
			}
		}
	}
}

