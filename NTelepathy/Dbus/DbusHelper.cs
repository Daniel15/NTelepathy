using System;
using System.Collections.Generic;
using DBus;
using org.freedesktop.DBus;

namespace NTelepathy
{
	public static class DbusHelper
	{
		/// <summary>
		/// Gets the specified DBus object along with its properties object
		/// </summary>
		/// <returns>The DBus object</returns>
		/// <param name='bus_name'>Name of the bus to get the object from</param>
		/// <param name='path'>Path to the object</param>
		/// <typeparam name='T'>Type of the object</typeparam>
		public static T GetWithProperties<T>(string bus_name, ObjectPath path) where T : DbusBase
		{
			T obj = Bus.Session.GetObject<T>(bus_name, path);
			Properties props = Bus.Session.GetObject<Properties>(bus_name, path);
			obj.Properties = props;
			return obj;
		}
		
		/// <summary>
		/// Gets the specified DBus objects along with their properties objects
		/// </summary>
		/// <returns>The DBus objects</returns>
		/// <param name='bus_name'>Name of the bus to get the object from</param>
		/// <param name='paths'>Paths to the object</param>
		/// <typeparam name='T'>Type of the objects</typeparam>
		public static IEnumerable<T> GetWithProperties<T>(string bus_name, ObjectPath[] paths) where T : DbusBase
		{
			IList<T> results = new List<T>(paths.Length);
			
			foreach (ObjectPath path in paths)
			{
				results.Add(GetWithProperties<T>(bus_name, path));
			}
			
			return results;
		}
	}
}

