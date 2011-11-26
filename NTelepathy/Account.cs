using System;
using DBus;
using NTelepathy.Dbus;

namespace NTelepathy
{
	/// <summary>
	/// Telepathy Account interface. Handles account details.
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Account.html</remarks>
	public abstract class Account : DbusBase, IAccount
	{
		/// <summary>
		/// Gets the connection for this account
		/// </summary>
		public ISimplePresence Connection
		{
			get
			{
				ObjectPath path = GetProperty<ObjectPath>(Constants.ACCOUNT_INTERFACE, "Connection");	
				return DbusHelper.GetWithProperties<Connection>(NTelepathy.Connection.BusName(path), path);
			}
		}
	}
}

