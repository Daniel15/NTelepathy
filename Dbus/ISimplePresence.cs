using System;
using DBus;

namespace NTelepathy.Dbus
{
	/// <summary>
	/// Telepathy SimplePresence interface
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Connection_Interface_Simple_Presence.html</remarks>
	[Interface("org.freedesktop.Telepathy.Connection.Interface.SimplePresence")]
	public interface ISimplePresence
	{
		/// <summary>
		/// Sets the current presence
		/// </summary>
		/// <param name='status'>Status (eg. "available", "busy")</param>
		/// <param name='statusMessage'>Status message</param>
		void SetPresence(string status, string statusMessage);
	}
}

