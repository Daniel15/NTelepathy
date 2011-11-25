using System.Collections.Generic;

namespace NTelepathy.Dbus
{
	/// <summary>
	/// Base class for all properties classes
	/// </summary>
	public abstract class PropertiesBase : org.freedesktop.DBus.Properties
	{
		// Below three methods are from Properties interface. They are 
		// implemented by the DBus proxy classes.
		public abstract object Get (string @interface, string propname);
		public abstract void Set (string @interface, string propname, object value);
		public abstract IDictionary<string, object> GetAll (string @interface);
	}
}

