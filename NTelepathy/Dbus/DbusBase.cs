using System;
using System.Reflection;
using DBus;
using org.freedesktop.DBus;
using NTelepathy;

namespace NTelepathy
{
	public abstract class DbusBase
	{
		/// <summary>
		/// Gets or sets the properties implementation for this object
		/// </summary>
		/// <value>The properties object</value>
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
		
		/// <summary>
		/// Gets the value of the specified property.
		/// </summary>
		/// <returns>The property value</returns>
		/// <param name='interface'>Interface to get property from</param>
		/// <param name='name'>Property name</param>
		/// <typeparam name='T'>Type of the property</typeparam>
		protected T GetProperty<T>(string @interface, string name)
		{
			return (T)Properties.Get(@interface, name);
		}
		
		/// <summary>
		/// Gets the value of the specified object property.
		/// </summary>
		/// <returns>The property value</returns>
		/// <param name='interface'>Interface to get property from</param>
		/// <param name='name'>Property name</param>
		/// <param name='bus_name'>Name of the bus to get the object from</param>
		/// <typeparam name='T'>Type of the property</typeparam>
		protected T GetProperty<T>(string @interface, string name, string bus_name) where T : DbusBase
		{
			ObjectPath path = GetProperty<ObjectPath>(@interface, name);	
			return DbusHelper.GetWithProperties<T>(bus_name, path);
		}
	}
}

