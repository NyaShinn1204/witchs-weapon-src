using System;

namespace Pathfinding.Serialization.JsonFx
{
	public class JsonNameAttribute : Attribute
	{
		private string jsonName;

		public string Name
		{
			get
			{
				return null;
			}
		}

		public JsonNameAttribute(string jsonName)
		{
		}

		public static string GetJsonName(object value)
		{
			return null;
		}
	}
}
