using DBus;

namespace NTelepathy.Dbus
{
	/// <summary>
	/// Properties for the Account interface
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Account.html</remarks>
	public abstract class AccountProperties : PropertiesBase
	{
		/// <summary>
		/// Gets the path to the connection for this account
		/// </summary>
		/// <value>The connection</value>
		public ObjectPath Connection
		{
			get
			{
				return (ObjectPath)Get(Constants.ACCOUNT_INTERFACE, "Connection");
			}
		}
	}
}

