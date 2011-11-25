using DBus;

namespace NTelepathy.Dbus
{
	/// <summary>
	/// Properties for AccountManager interface
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Account_Manager.html</remarks>
	public abstract class AccountManagerProperties : PropertiesBase
	{
		/// <summary>
		/// Get all the valid accounts this account manager knows about
		/// </summary>
		/// <value>The accounts</value>
		public ObjectPath[] ValidAccounts
		{
			get
			{
				return (ObjectPath[])Get(Constants.ACCOUNTMANAGER_INTERFACE, "ValidAccounts");
			}
		}
	}
}

