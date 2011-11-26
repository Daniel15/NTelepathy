using System;
using DBus;

namespace NTelepathy
{
	/// <summary>
	/// Telepathy connection interface.
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Connection.html</remarks>
	public abstract class Connection : DbusBase, IConnection, ISimplePresence
	{
		/// <summary>
		/// Sets the current presence
		/// </summary>
		/// <param name='status'>Status (eg. "available", "busy")</param>
		/// <param name='statusMessage'>Status message</param>
		public abstract void SetPresence (string status, string statusMessage);		
		
		/// <summary>
		/// Gets the bus name for the specified connection manager object path
		/// </summary>
		/// <returns>The bus name</returns>
		/// <param name='objectPath'>The object path</param>
		public static string BusName(ObjectPath objectPath)
		{
			// TODO: Is there a better (proper?) way to do this?
			
			// ObjectPath is eg. /org/freedesktop/Telepathy/Connection/gabble/jabber/daniel_40d15_2ebiz_2f3e9348f3
			// Connection manager type is 5th item (eg. "gabble")
			string connType = objectPath.ToString().Split('/')[5];
			
			return string.Format("org.freedesktop.Telepathy.ConnectionManager.{0}", connType);
		}
	}
}

