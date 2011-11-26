using System;
using NTelepathy.Dbus;
using DBus;

namespace NTelepathy
{
	/// <summary>
	/// Telepathy SimplePresence interface
	/// </summary>
	/// <remarks>Reference: http://telepathy.freedesktop.org/spec-0.20/Connection_Interface_Simple_Presence.html</remarks>
	[Interface(Constants.SIMPLEPRESENCE_INTERFACE)]
	public interface ISimplePresence : IConnection
	{
		/// <summary>
		/// Sets the current presence
		/// </summary>
		/// <param name='status'>Status (eg. "available", "busy")</param>
		/// <param name='statusMessage'>Status message</param>
		void SetPresence(string status, string statusMessage);
	}
}

