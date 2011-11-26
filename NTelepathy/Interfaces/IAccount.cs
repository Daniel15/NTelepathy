using System;
using DBus;
using NTelepathy.Dbus;

namespace NTelepathy
{
	/// <summary>
	/// Telepathy Account interface. Handles account details.
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Account.html</remarks>
	[Interface(Constants.ACCOUNT_INTERFACE)]
	public interface IAccount
	{
		/// <summary>
		/// Gets the connection for this account
		/// </summary>
		ISimplePresence Connection { get; }
	}
}

