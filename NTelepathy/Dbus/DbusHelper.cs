using System;
using System.Collections.Generic;
using DBus;
using org.freedesktop.DBus;

namespace NTelepathy
{
	public static class DbusHelper
	{
		public static T GetWithProperties<T>(string bus_name, ObjectPath path) where T : DbusBase
		{
			T obj = Bus.Session.GetObject<T>(bus_name, path);
			Properties props = Bus.Session.GetObject<Properties>(bus_name, path);
			obj.Properties = props;
			return obj;
		}
		
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

