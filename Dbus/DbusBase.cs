using System;
using System.Reflection;
using DBus;
using org.freedesktop.DBus;
using NTelepathy;

namespace NTelepathy
{
	public abstract class DbusBase
	{
		public Properties Properties { get; set; }
		
		/*protected string Interface
		{
			get
			{
				InterfaceAttribute attrib = (InterfaceAttribute)Attribute
					.GetCustomAttribute(GetType(), typeof(InterfaceAttribute), true);
				
				return attrib.Name;
			}
		}*/
		
		protected T GetProperty<T>(string @interface, string name)
		{
			return (T)Properties.Get(@interface, name);
		}
		
		protected T GetProperty<T>(string @interface, string name, string bus_name) where T : DbusBase
		{
			ObjectPath path = GetProperty<ObjectPath>(@interface, name);	
			return DbusHelper.GetWithProperties<T>(bus_name, path);
		}
	}
}

