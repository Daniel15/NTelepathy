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
	[Interface(Constants.ACCOUNTMANAGER_INTERFACE)]
	public interface IAccountManager
	{
		/// <summary>
		/// Get all the valid accounts this account manager knows about
		/// </summary>
		/// <value>The accounts</value>
		IEnumerable<IAccount> ValidAccounts { get; }
	}
}

